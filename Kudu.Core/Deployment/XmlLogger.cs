﻿using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Linq;
using System.Xml.Linq;

namespace Kudu.Core.Deployment
{
    public class XmlLogger : ILogger
    {
        private readonly string _path;
        private readonly IFileSystem _fileSystem;
        private readonly static object LogLock = new object();

        public XmlLogger(IFileSystem fileSystem, string path)
        {
            _fileSystem = fileSystem;
            _path = path;
        }

        public ILogger Log(string value, LogEntryType type)
        {
            var xmlLogEntry = new XElement("entry",
                                           new XAttribute("time", DateTime.Now),
                                           new XAttribute("id", Guid.NewGuid()),
                                           new XAttribute("type", (int)type),
                                           new XElement("message", value));

            lock (LogLock)
            {
                XDocument document = GetDocument();
                document.Root.Add(xmlLogEntry);
                document.Save(_path);
            }

            return new InnerXmlLogger(this, xmlLogEntry);
        }

        public IEnumerable<LogEntry> GetLogEntries()
        {
            XDocument document;
            lock (LogLock)
            {
                document = GetDocument();
            }

            return from e in document.Root.Elements("entry")
                   let time = DateTime.Parse(e.Attribute("time").Value)
                   let type = (LogEntryType)Int32.Parse(e.Attribute("type").Value)
                   select new LogEntry(time, e.Attribute("id").Value, e.Element("message").Value, type);
        }

        public IEnumerable<LogEntry> GetLogEntryDetails(string entryId)
        {
            XDocument document;
            lock (LogLock)
            {
                document = GetDocument();
            }

            return from e in document.Root.Elements("entry").Where(s => s.Attribute("id").Value == entryId).First().Elements("entry")
                   let time = DateTime.Parse(e.Attribute("time").Value)
                   let type = (LogEntryType)Int32.Parse(e.Attribute("type").Value)
                   select new LogEntry(time, e.Attribute("id").Value, e.Element("message").Value, type);
        }

        public string GetFirstErrorEntryMessage()
        {
            XDocument document;
            lock (LogLock)
            {
                document = GetDocument();
            }

            var firstErrorEntry = document.Root.Elements("entry").First(s => s.Attribute("type").Value == ((int)(LogEntryType.Error)).ToString());
            if (firstErrorEntry != null)
            {
                return firstErrorEntry.Element("message").Value;
            }

            return "No error found in log.";
        }

        private XDocument GetDocument()
        {
            if (!_fileSystem.File.Exists(_path))
            {
                return new XDocument(new XElement("entries"));
            }

            XDocument document;
            using (var stream = _fileSystem.File.OpenRead(_path))
            {
                document = XDocument.Load(stream);
            }

            return document;
        }

        private class InnerXmlLogger : ILogger
        {
            private readonly XmlLogger _parent;
            private readonly XElement _element;

            public InnerXmlLogger(XmlLogger parent, XElement element)
            {
                _parent = parent;
                _element = element;
            }

            public ILogger Log(string value, LogEntryType type)
            {
                var xmlLogEntry = new XElement("entry",
                                               new XAttribute("time", DateTime.Now),
                                               new XAttribute("id", Guid.NewGuid()),
                                               new XAttribute("type", (int)type),
                                               new XElement("message", value));

                lock (LogLock)
                {
                    var document = _parent.GetDocument();
                    var parentLogEntry = document.Root
                        .Elements()
                        .Where(s => s.Attribute("id").Value == _element.Attribute("id").Value)
                        .First();
                    parentLogEntry.Add(xmlLogEntry);
                    // adjust log level of the parent log entry
                    var parentLogEntryType = (LogEntryType)Enum.Parse(typeof(LogEntryType), parentLogEntry.Attribute("type").Value);
                    if (type > parentLogEntryType)
                    {
                        parentLogEntry.Attribute("type").SetValue((int)type);
                    }
                    document.Save(_parent._path);
                }

                // Support a depthness of 2 for now.
                return this;
            }
        }
    }
}
