﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TmTech_v1.View.Customer {
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
    internal class CompanyResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CompanyResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TmTech_v1.View.Customer.CompanyResource", typeof(CompanyResource).Assembly);
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
        ///   Looks up a localized string similar to Bạn có muốn cập nhật thông tin công ty.
        /// </summary>
        internal static string CompanyUpdateQuestion {
            get {
                return ResourceManager.GetString("CompanyUpdateQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bạn có đồng ý vô hiệu hóa công ty không.
        /// </summary>
        internal static string DisableCompanyAlert {
            get {
                return ResourceManager.GetString("DisableCompanyAlert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vô hiệu hóa.
        /// </summary>
        internal static string DisableCompanyCapton {
            get {
                return ResourceManager.GetString("DisableCompanyCapton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Không có thông tin công ty cập nhật.
        /// </summary>
        internal static string NoCompanyUpdate {
            get {
                return ResourceManager.GetString("NoCompanyUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Không có thông tin khách hàng  đại diện cập nhật.
        /// </summary>
        internal static string NoDeputyUpdate {
            get {
                return ResourceManager.GetString("NoDeputyUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cảnh báo thao tác.
        /// </summary>
        internal static string WarningOperator {
            get {
                return ResourceManager.GetString("WarningOperator", resourceCulture);
            }
        }
    }
}
