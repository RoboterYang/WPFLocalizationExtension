﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssemblyTest {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AssemblyTest.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Aqua.
        /// </summary>
        internal static string Brush {
            get {
                return ResourceManager.GetString("Brush", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to de.
        /// </summary>
        internal static string ButtonDE {
            get {
                return ResourceManager.GetString("ButtonDE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to en.
        /// </summary>
        internal static string ButtonEN {
            get {
                return ResourceManager.GetString("ButtonEN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LeftToRight.
        /// </summary>
        internal static string Flow {
            get {
                return ResourceManager.GetString("Flow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 10,5,20,15.
        /// </summary>
        internal static string Padding {
            get {
                return ResourceManager.GetString("Padding", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap TestImage {
            get {
                object obj = ResourceManager.GetObject("TestImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is a test..
        /// </summary>
        internal static string TestText {
            get {
                return ResourceManager.GetString("TestText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 75.
        /// </summary>
        internal static string Width {
            get {
                return ResourceManager.GetString("Width", resourceCulture);
            }
        }
    }
}
