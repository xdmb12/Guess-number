﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GuessNumber.Resources {
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
    internal class GameResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal GameResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GuessNumber.Resources.GameResources", typeof(GameResources).Assembly);
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
        ///   Looks up a localized string similar to Number of your attempts: .
        /// </summary>
        internal static string Attempts {
            get {
                return ResourceManager.GetString("Attempts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter a number: .
        /// </summary>
        internal static string EnterPhrase {
            get {
                return ResourceManager.GetString("EnterPhrase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error! Put the number with right format!.
        /// </summary>
        internal static string ErrorPhrase {
            get {
                return ResourceManager.GetString("ErrorPhrase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to My number is bigger!.
        /// </summary>
        internal static string NumberBigger {
            get {
                return ResourceManager.GetString("NumberBigger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to My number is smaller!.
        /// </summary>
        internal static string NumberSmaller {
            get {
                return ResourceManager.GetString("NumberSmaller", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you wanna play more(Y/N)?.
        /// </summary>
        internal static string ReadyOrNot {
            get {
                return ResourceManager.GetString("ReadyOrNot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You won this game!!!.
        /// </summary>
        internal static string WinPhrase {
            get {
                return ResourceManager.GetString("WinPhrase", resourceCulture);
            }
        }
    }
}
