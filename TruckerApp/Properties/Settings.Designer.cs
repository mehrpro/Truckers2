﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TruckerApp.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastVideoPath {
            get {
                return ((string)(this["LastVideoPath"]));
            }
            set {
                this["LastVideoPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ارتباط با دوربین به درستی برقرار نشده، دوباره تلاش کنید")]
        public string FrmFishPrint_HandleAnprEvents_CameraNotConnected {
            get {
                return ((string)(this["FrmFishPrint_HandleAnprEvents_CameraNotConnected"]));
            }
            set {
                this["FrmFishPrint_HandleAnprEvents_CameraNotConnected"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ارتباط با فایل یا دوربین برقرار نشد. آدرس را بررسی کرده و اگر نام کاربری و رمز می" +
            " خواهد آنها را بازبینی کنید.")]
        public string FrmFishPrint_HandleAnprEvents_NotConnectedToCamera {
            get {
                return ((string)(this["FrmFishPrint_HandleAnprEvents_NotConnectedToCamera"]));
            }
            set {
                this["FrmFishPrint_HandleAnprEvents_NotConnectedToCamera"] = value;
            }
        }
    }
}
