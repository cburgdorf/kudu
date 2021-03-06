﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kudu.Core {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Kudu.Core.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copied &apos;{0}&apos;..
        /// </summary>
        internal static string Copied {
            get {
                return ResourceManager.GetString("Copied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to determine which project file to build. {0}..
        /// </summary>
        internal static string Error_AmbiguousProjects {
            get {
                return ResourceManager.GetString("Error_AmbiguousProjects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to determine which solution file to build. {0}..
        /// </summary>
        internal static string Error_AmbiguousSolutions {
            get {
                return ResourceManager.GetString("Error_AmbiguousSolutions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to deploy &apos;{0}&apos;. No deployment found..
        /// </summary>
        internal static string Error_DeployNotFound {
            get {
                return ResourceManager.GetString("Error_DeployNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to locate &apos;git.exe&apos;. Make sure it is installed..
        /// </summary>
        internal static string Error_FailedToLocateGit {
            get {
                return ResourceManager.GetString("Error_FailedToLocateGit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No log found for &apos;{0}&apos;..
        /// </summary>
        internal static string Error_NoLogFound {
            get {
                return ResourceManager.GetString("Error_NoLogFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified path &apos;{0}&apos; doesn&apos;t exist..
        /// </summary>
        internal static string Error_ProjectDoesNotExist {
            get {
                return ResourceManager.GetString("Error_ProjectDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a deployable project..
        /// </summary>
        internal static string Error_ProjectNotDeployable {
            get {
                return ResourceManager.GetString("Error_ProjectNotDeployable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to delete &apos;{0}&apos;. The deployment is currently active..
        /// </summary>
        internal static string Error_UnableToDeleteDeploymentActive {
            get {
                return ResourceManager.GetString("Error_UnableToDeleteDeploymentActive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to delete &apos;{0}&apos;. No deployment found..
        /// </summary>
        internal static string Error_UnableToDeleteNoDeploymentFound {
            get {
                return ResourceManager.GetString("Error_UnableToDeleteNoDeploymentFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported status &apos;{0}&apos;..
        /// </summary>
        internal static string Error_UnsupportedStatus {
            get {
                return ResourceManager.GetString("Error_UnsupportedStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Building solution &apos;{0}&apos;..
        /// </summary>
        internal static string Log_BuildingSolution {
            get {
                return ResourceManager.GetString("Log_BuildingSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Building web project &apos;{0}&apos;..
        /// </summary>
        internal static string Log_BuildingWebProject {
            get {
                return ResourceManager.GetString("Log_BuildingWebProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cleaning git repository..
        /// </summary>
        internal static string Log_CleaningGitRepository {
            get {
                return ResourceManager.GetString("Log_CleaningGitRepository", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment &apos;{0}&apos; already active..
        /// </summary>
        internal static string Log_DeploymentAlreadyActive {
            get {
                return ResourceManager.GetString("Log_DeploymentAlreadyActive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment successful..
        /// </summary>
        internal static string Log_DeploymentSuccessful {
            get {
                return ResourceManager.GetString("Log_DeploymentSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading NPM packages..
        /// </summary>
        internal static string Log_DownloadingNodePackages {
            get {
                return ResourceManager.GetString("Log_DownloadingNodePackages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New deployment received..
        /// </summary>
        internal static string Log_NewDeploymentReceived {
            get {
                return ResourceManager.GetString("Log_NewDeploymentReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found solution &apos;{0}&apos; with no deployable projects. Deploying files instead..
        /// </summary>
        internal static string Log_NoDeployableProjects {
            get {
                return ResourceManager.GetString("Log_NoDeployableProjects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment skipped. Received push for &apos;{0}&apos; branch, and only pushes to &apos;master&apos; are deployed..
        /// </summary>
        internal static string Log_NonMasterBranchPushed {
            get {
                return ResourceManager.GetString("Log_NonMasterBranchPushed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NPM not installed or couldn&apos;t be located. Skipping package installation..
        /// </summary>
        internal static string Log_NpmNotInstalled {
            get {
                return ResourceManager.GetString("Log_NpmNotInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Packages already installed..
        /// </summary>
        internal static string Log_PackagesAlreadyInstalled {
            get {
                return ResourceManager.GetString("Log_PackagesAlreadyInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preparing deployment for commit id &apos;{0}&apos;..
        /// </summary>
        internal static string Log_PreparingDeployment {
            get {
                return ResourceManager.GetString("Log_PreparingDeployment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preparing files for deployment..
        /// </summary>
        internal static string Log_PreparingFiles {
            get {
                return ResourceManager.GetString("Log_PreparingFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unknown error has occured. Check the diagnostic log for details..
        /// </summary>
        internal static string Log_UnexpectedError {
            get {
                return ResourceManager.GetString("Log_UnexpectedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating branch &apos;{0}&apos;..
        /// </summary>
        internal static string Log_UpdatingBranch {
            get {
                return ResourceManager.GetString("Log_UpdatingBranch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using website project &apos;{0}&apos;..
        /// </summary>
        internal static string Log_UsingWebsiteProject {
            get {
                return ResourceManager.GetString("Log_UsingWebsiteProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Building and Deploying &apos;{0}&apos;..
        /// </summary>
        internal static string Status_BuildingAndDeploying {
            get {
                return ResourceManager.GetString("Status_BuildingAndDeploying", resourceCulture);
            }
        }
    }
}
