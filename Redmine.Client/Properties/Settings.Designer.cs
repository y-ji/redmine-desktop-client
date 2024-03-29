﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Redmine.Client.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("my username")]
        public string RedmineUser {
            get {
                return ((string)(this["RedmineUser"]));
            }
            set {
                this["RedmineUser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://redmine.example.org")]
        public string RedmineURL {
            get {
                return ((string)(this["RedmineURL"]));
            }
            set {
                this["RedmineURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("my password")]
        public string RedminePassword {
            get {
                return ((string)(this["RedminePassword"]));
            }
            set {
                this["RedminePassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool RedmineAuthentication {
            get {
                return ((bool)(this["RedmineAuthentication"]));
            }
            set {
                this["RedmineAuthentication"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CheckForUpdates {
            get {
                return ((bool)(this["CheckForUpdates"]));
            }
            set {
                this["CheckForUpdates"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MinimizeToSystemTray {
            get {
                return ((bool)(this["MinimizeToSystemTray"]));
            }
            set {
                this["MinimizeToSystemTray"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MinimizeOnStartTimer {
            get {
                return ((bool)(this["MinimizeOnStartTimer"]));
            }
            set {
                this["MinimizeOnStartTimer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int PopupInterval {
            get {
                return ((int)(this["PopupInterval"]));
            }
            set {
                this["PopupInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int CacheLifetime {
            get {
                return ((int)(this["CacheLifetime"]));
            }
            set {
                this["CacheLifetime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("540")]
        public int MainWindowSizeX {
            get {
                return ((int)(this["MainWindowSizeX"]));
            }
            set {
                this["MainWindowSizeX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("460")]
        public int MainWindowSizeY {
            get {
                return ((int)(this["MainWindowSizeY"]));
            }
            set {
                this["MainWindowSizeY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int LastProjectId {
            get {
                return ((int)(this["LastProjectId"]));
            }
            set {
                this["LastProjectId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int LastIssueId {
            get {
                return ((int)(this["LastIssueId"]));
            }
            set {
                this["LastIssueId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int LastActivityId {
            get {
                return ((int)(this["LastActivityId"]));
            }
            set {
                this["LastActivityId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en")]
        public string LanguageCode {
            get {
                return ((string)(this["LanguageCode"]));
            }
            set {
                this["LanguageCode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int ApiVersion {
            get {
                return ((int)(this["ApiVersion"]));
            }
            set {
                this["ApiVersion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ClosedStatus {
            get {
                return ((int)(this["ClosedStatus"]));
            }
            set {
                this["ClosedStatus"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool OnlyAssignedToMe {
            get {
                return ((bool)(this["OnlyAssignedToMe"]));
            }
            set {
                this["OnlyAssignedToMe"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsTicking {
            get {
                return ((bool)(this["IsTicking"]));
            }
            set {
                this["IsTicking"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int TickingTicks {
            get {
                return ((int)(this["TickingTicks"]));
            }
            set {
                this["TickingTicks"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool PauseTickingOnLock {
            get {
                return ((bool)(this["PauseTickingOnLock"]));
            }
            set {
                this["PauseTickingOnLock"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UpdateIssueIfNew {
            get {
                return ((bool)(this["UpdateIssueIfNew"]));
            }
            set {
                this["UpdateIssueIfNew"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int NewStatus {
            get {
                return ((int)(this["NewStatus"]));
            }
            set {
                this["NewStatus"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int InProgressStatus {
            get {
                return ((int)(this["InProgressStatus"]));
            }
            set {
                this["InProgressStatus"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("492")]
        public int IssueWindowSizeX {
            get {
                return ((int)(this["IssueWindowSizeX"]));
            }
            set {
                this["IssueWindowSizeX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("374")]
        public int IssueWindowSizeY {
            get {
                return ((int)(this["IssueWindowSizeY"]));
            }
            set {
                this["IssueWindowSizeY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AddNoteOnChangeStatus {
            get {
                return ((bool)(this["AddNoteOnChangeStatus"]));
            }
            set {
                this["AddNoteOnChangeStatus"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("None")]
        public global::System.Windows.Forms.SortOrder IssueGridSortOrder {
            get {
                return ((global::System.Windows.Forms.SortOrder)(this["IssueGridSortOrder"]));
            }
            set {
                this["IssueGridSortOrder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Id")]
        public string IssueGridSortColumn {
            get {
                return ((string)(this["IssueGridSortColumn"]));
            }
            set {
                this["IssueGridSortColumn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IssueGridHeader_ShowAssignedTo {
            get {
                return ((bool)(this["IssueGridHeader_ShowAssignedTo"]));
            }
            set {
                this["IssueGridHeader_ShowAssignedTo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IssueGridHeader_ShowCategory {
            get {
                return ((bool)(this["IssueGridHeader_ShowCategory"]));
            }
            set {
                this["IssueGridHeader_ShowCategory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IssueGridHeader_ShowParentIssue {
            get {
                return ((bool)(this["IssueGridHeader_ShowParentIssue"]));
            }
            set {
                this["IssueGridHeader_ShowParentIssue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IssueGridHeader_ShowPriority {
            get {
                return ((bool)(this["IssueGridHeader_ShowPriority"]));
            }
            set {
                this["IssueGridHeader_ShowPriority"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IssueGridHeader_ShowProject {
            get {
                return ((bool)(this["IssueGridHeader_ShowProject"]));
            }
            set {
                this["IssueGridHeader_ShowProject"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IssueGridHeader_ShowStatus {
            get {
                return ((bool)(this["IssueGridHeader_ShowStatus"]));
            }
            set {
                this["IssueGridHeader_ShowStatus"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IssueGridHeader_ShowFixedVersion {
            get {
                return ((bool)(this["IssueGridHeader_ShowFixedVersion"]));
            }
            set {
                this["IssueGridHeader_ShowFixedVersion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("xml")]
        public global::Redmine.Net.Api.MimeFormat CommunicationType {
            get {
                return ((global::Redmine.Net.Api.MimeFormat)(this["CommunicationType"]));
            }
            set {
                this["CommunicationType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool OnlyMyProjects {
            get {
                return ((bool)(this["OnlyMyProjects"]));
            }
            set {
                this["OnlyMyProjects"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpgradeSettings {
            get {
                return ((bool)(this["UpgradeSettings"]));
            }
            set {
                this["UpgradeSettings"] = value;
            }
        }
    }
}
