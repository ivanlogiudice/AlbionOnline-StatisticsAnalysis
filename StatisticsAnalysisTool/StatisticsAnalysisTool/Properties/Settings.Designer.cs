﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StatisticsAnalysisTool.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10000")]
        public int RefreshRate {
            get {
                return ((int)(this["RefreshRate"]));
            }
            set {
                this["RefreshRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Languages")]
        public string LanguageDirectoryName {
            get {
                return ((string)(this["LanguageDirectoryName"]));
            }
            set {
                this["LanguageDirectoryName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("settings.ini")]
        public string SettingsFileName {
            get {
                return ((string)(this["SettingsFileName"]));
            }
            set {
                this["SettingsFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ImageResources")]
        public string ImageResources {
            get {
                return ((string)(this["ImageResources"]));
            }
            set {
                this["ImageResources"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ItemList.json")]
        public string ItemListFileName {
            get {
                return ((string)(this["ItemListFileName"]));
            }
            set {
                this["ItemListFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7")]
        public int UpdateItemListByDays {
            get {
                return ((int)(this["UpdateItemListByDays"]));
            }
            set {
                this["UpdateItemListByDays"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public string ActiveMode {
            get {
                return ((string)(this["ActiveMode"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=LEM458PZ4FV4" +
            "C&source=url")]
        public string DonateUrl {
            get {
                return ((string)(this["DonateUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/broderickhyman/ao-bin-dumps/master/formatted/it" +
            "ems.json")]
        public string DefaultItemListSourceUrl {
            get {
                return ((string)(this["DefaultItemListSourceUrl"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/Triky313/AlbionOnline-StatisticsAnalysis/master" +
            "/StatisticsAnalysisTool/StatisticsAnalysisTool/ao-update-check.xml")]
        public string AutoUpdateConfigUrl {
            get {
                return ((string)(this["AutoUpdateConfigUrl"]));
            }
            set {
                this["AutoUpdateConfigUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double MainWindowHeight {
            get {
                return ((double)(this["MainWindowHeight"]));
            }
            set {
                this["MainWindowHeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double MainWindowWidth {
            get {
                return ((double)(this["MainWindowWidth"]));
            }
            set {
                this["MainWindowWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MainWindowMaximized {
            get {
                return ((bool)(this["MainWindowMaximized"]));
            }
            set {
                this["MainWindowMaximized"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/broderickhyman/ao-bin-dumps/master/formatted/it" +
            "ems.json")]
        public string CurrentItemListSourceUrl {
            get {
                return ((string)(this["CurrentItemListSourceUrl"]));
            }
            set {
                this["CurrentItemListSourceUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en-EN")]
        public string CurrentLanguageCulture {
            get {
                return ((string)(this["CurrentLanguageCulture"]));
            }
            set {
                this["CurrentLanguageCulture"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SavedPlayerInformationName {
            get {
                return ((string)(this["SavedPlayerInformationName"]));
            }
            set {
                this["SavedPlayerInformationName"] = value;
            }
        }
    }
}
