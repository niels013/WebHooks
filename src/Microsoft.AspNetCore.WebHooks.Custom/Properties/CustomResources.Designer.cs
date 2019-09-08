﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNetCore.WebHooks.Custom.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CustomResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CustomResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNetCore.WebHooks.Custom.Properties.CustomResources", typeof(CustomResources).Assembly);
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
        ///   Looks up a localized string similar to Listen in on all events..
        /// </summary>
        internal static string Filter_WildcardDescription {
            get {
                return ResourceManager.GetString("Filter_WildcardDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not resolve WebHook filters due to error: {0}.
        /// </summary>
        internal static string FilterManager_FailureGettingFilters {
            get {
                return ResourceManager.GetString("FilterManager_FailureGettingFilters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failure shutting down launchers: &apos;{0}&apos;.
        /// </summary>
        internal static string Manager_CompletionFailure {
            get {
                return ResourceManager.GetString("Manager_CompletionFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Giving up sending WebHook &apos;{0}&apos; after &apos;{1}&apos; attempts..
        /// </summary>
        internal static string Manager_GivingUp {
            get {
                return ResourceManager.GetString("Manager_GivingUp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not add header field &apos;{0}&apos; to the WebHook request for WebHook ID &apos;{1}&apos;..
        /// </summary>
        internal static string Manager_InvalidHeader {
            get {
                return ResourceManager.GetString("Manager_InvalidHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook registrar requested no verification of WebHook URI..
        /// </summary>
        internal static string Manager_NoEcho {
            get {
                return ResourceManager.GetString("Manager_NoEcho", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook URI must be absolute with a scheme of either &apos;http&apos; or &apos;https&apos; but received &apos;{0}&apos;..
        /// </summary>
        internal static string Manager_NoHttpUri {
            get {
                return ResourceManager.GetString("Manager_NoHttpUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not determine the user ID from the given principal..
        /// </summary>
        internal static string Manager_NoUser {
            get {
                return ResourceManager.GetString("Manager_NoUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WebHook &apos;{0}&apos; resulted in status code &apos;{1}&apos; on attempt &apos;{2}&apos;..
        /// </summary>
        internal static string Manager_Result {
            get {
                return ResourceManager.GetString("Manager_Result", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuring &apos;{0}&apos; with a total of {1} attempt(s) of sending WebHooks..
        /// </summary>
        internal static string Manager_Started {
            get {
                return ResourceManager.GetString("Manager_Started", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The HTTP request echo query parameter was not returned as plain text in the response. Please return the echo parameter to verify that the WebHook is working as expected..
        /// </summary>
        internal static string Manager_VerifyBadEcho {
            get {
                return ResourceManager.GetString("Manager_VerifyBadEcho", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WebHook verification failed. Please ensure that the WebHook URI is valid and that the endpoint is accessible. Error encountered: {0}.
        /// </summary>
        internal static string Manager_VerifyFailure {
            get {
                return ResourceManager.GetString("Manager_VerifyFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook URI did not return the expected echo query parameter value in a plain text response body. This is necessary to ensure that the WebHook is connected correctly..
        /// </summary>
        internal static string Manager_VerifyNoBody {
            get {
                return ResourceManager.GetString("Manager_VerifyNoBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to submit attempt {0} of WebHook {1} due to failure: {2}.
        /// </summary>
        internal static string Manager_WebHookFailure {
            get {
                return ResourceManager.GetString("Manager_WebHookFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Notification setting was found with key &apos;{0}&apos;..
        /// </summary>
        internal static string Notification_KeyNotFound {
            get {
                return ResourceManager.GetString("Notification_KeyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following filters are not valid: &apos;{0}&apos;..
        /// </summary>
        internal static string RegistrationsManager_InvalidFilters {
            get {
                return ResourceManager.GetString("RegistrationsManager_InvalidFilters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid &apos;{0}&apos; instance: &apos;{1}&apos; cannot be null..
        /// </summary>
        internal static string Sender_BadWorkItem {
            get {
                return ResourceManager.GetString("Sender_BadWorkItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook secret key parameter must be between 32 and 64 characters long..
        /// </summary>
        internal static string WebHook_InvalidSecret {
            get {
                return ResourceManager.GetString("WebHook_InvalidSecret", resourceCulture);
            }
        }
    }
}
