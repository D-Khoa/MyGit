﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Properties {
    
    
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
        [global::System.Configuration.DefaultSettingValueAttribute("Server=192.168.145.12;Port=5432;UserId=mes;Password=dbuser;Database=mesdb;")]
        public string CONNECTION_STRING {
            get {
                return ((string)(this["CONNECTION_STRING"]));
            }
            set {
                this["CONNECTION_STRING"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Com.Nidec.Mes.Common.Basic.MachineMaintenance.MainForm")]
        public string ApplicationTypeName {
            get {
                return ((string)(this["ApplicationTypeName"]));
            }
            set {
                this["ApplicationTypeName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public string AUTHENTIFICATE_FLAG {
            get {
                return ((string)(this["AUTHENTIFICATE_FLAG"]));
            }
            set {
                this["AUTHENTIFICATE_FLAG"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Singapore Standard Time")]
        public string SERVER_TIME_ZONE {
            get {
                return ((string)(this["SERVER_TIME_ZONE"]));
            }
            set {
                this["SERVER_TIME_ZONE"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Settings")]
        public string APPLICATION_ENVIRONMENT_SETTINGS {
            get {
                return ((string)(this["APPLICATION_ENVIRONMENT_SETTINGS"]));
            }
            set {
                this["APPLICATION_ENVIRONMENT_SETTINGS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("NCVP MANAGEMENT SYSTEM")]
        public string APPLICATION_ENVIRONMENT_HEADER {
            get {
                return ((string)(this["APPLICATION_ENVIRONMENT_HEADER"]));
            }
            set {
                this["APPLICATION_ENVIRONMENT_HEADER"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("NCVP MANAGEMENT SYSTEM")]
        public string APPLICATION_HEADER {
            get {
                return ((string)(this["APPLICATION_HEADER"]));
            }
            set {
                this["APPLICATION_HEADER"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Server=192.168.145.12;Port=5432;UserId=pqm;Password=dbuser;Database=pqmdb;")]
        public string PQM_CONNECTION_STRING {
            get {
                return ((string)(this["PQM_CONNECTION_STRING"]));
            }
            set {
                this["PQM_CONNECTION_STRING"] = value;
            }
        }
    }
}
