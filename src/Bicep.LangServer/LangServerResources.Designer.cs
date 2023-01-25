//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bicep.LanguageServer {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    ///   This class was generated by MSBuild using the GenerateResource task.
    ///   To add or remove a member, edit your .resx file then rerun MSBuild.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Build.Tasks.StronglyTypedResourceBuilder", "15.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class LangServerResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LangServerResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Bicep.LanguageServer.LangServerResources", typeof(LangServerResources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created new subfolder for output files: {0}.
        /// </summary>
        public static string Decompile_CreatedNewSubfolder {
            get {
                return ResourceManager.GetString("Decompile_CreatedNewSubfolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Decompilation failed. Please fix the following problems and try again: {0}.
        /// </summary>
        public static string Decompile_DecompilationFailed {
            get {
                return ResourceManager.GetString("Decompile_DecompilationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Decompiling {0} into Bicep....
        /// </summary>
        public static string Decompile_DecompilationStartMsg {
            get {
                return ResourceManager.GetString("Decompile_DecompilationStartMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment failed for {0}..
        /// </summary>
        public static string DeploymentFailedMessage {
            get {
                return ResourceManager.GetString("DeploymentFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment failed for {0}. {1}.
        /// </summary>
        public static string DeploymentFailedWithExceptionMessage {
            get {
                return ResourceManager.GetString("DeploymentFailedWithExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment started for {0}..
        /// </summary>
        public static string DeploymentStartedMessage {
            get {
                return ResourceManager.GetString("DeploymentStartedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment succeeded for {0}..
        /// </summary>
        public static string DeploymentSucceededMessage {
            get {
                return ResourceManager.GetString("DeploymentSucceededMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disable {0} for this line.
        /// </summary>
        public static string DisableDiagnosticForThisLine {
            get {
                return ResourceManager.GetString("DisableDiagnosticForThisLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit {0} in bicepconfig.json.
        /// </summary>
        public static string EditLinterRuleActionTitle {
            get {
                return ResourceManager.GetString("EditLinterRuleActionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encountered error while reading parameters file: {0}. Please fix the following issue: {1}.
        /// </summary>
        public static string InvalidParameterFile {
            get {
                return ResourceManager.GetString("InvalidParameterFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment failed for {0}. Please fix following issues in the parameter file {1}: {2}.
        /// </summary>
        public static string InvalidParameterFileDeploymentFailedMessage {
            get {
                return ResourceManager.GetString("InvalidParameterFileDeploymentFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment failed for {0}. Please provide a valid value for parameter: {1}.
        /// </summary>
        public static string InvalidParameterValueDeploymentFailedMessage {
            get {
                return ResourceManager.GetString("InvalidParameterValueDeploymentFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment failed for {0}. Please provide a valid location..
        /// </summary>
        public static string MissingLocationDeploymentFailedMessage {
            get {
                return ResourceManager.GetString("MissingLocationDeploymentFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameters of type array or object should either contain a default value or must be specified in parameters.json file. Please update the value for the following parameters: {0}.
        /// </summary>
        public static string MissingParamValueForArrayOrObjectType {
            get {
                return ResourceManager.GetString("MissingParamValueForArrayOrObjectType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported target scope: {0}..
        /// </summary>
        public static string UnsupportedTargetScopeMessage {
            get {
                return ResourceManager.GetString("UnsupportedTargetScopeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View deployment in portal: {0}..
        /// </summary>
        public static string ViewDeploymentInPortalMessage {
            get {
                return ResourceManager.GetString("ViewDeploymentInPortalMessage", resourceCulture);
            }
        }
    }
}
