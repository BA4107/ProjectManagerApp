#pragma checksum "..\..\..\Pop-ups\Edit_Subtask_Popup.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7B24AC8DFCDDE9D8D1CD5B710311C02DBA4B098892283A8D4739100BF5986D42"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Project_Management_App_2.Pop_ups;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Project_Management_App_2.Pop_ups {
    
    
    /// <summary>
    /// Edit_Subtask_Popup
    /// </summary>
    public partial class Edit_Subtask_Popup : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Pop-ups\Edit_Subtask_Popup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEditSubtaskName;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pop-ups\Edit_Subtask_Popup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChange_SubtaskDetails;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pop-ups\Edit_Subtask_Popup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelPopup;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pop-ups\Edit_Subtask_Popup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteSubtask;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Project Management App 2;component/pop-ups/edit_subtask_popup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pop-ups\Edit_Subtask_Popup.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtEditSubtaskName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnChange_SubtaskDetails = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Pop-ups\Edit_Subtask_Popup.xaml"
            this.btnChange_SubtaskDetails.Click += new System.Windows.RoutedEventHandler(this.btnChange_SubtaskDetails_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnCancelPopup = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Pop-ups\Edit_Subtask_Popup.xaml"
            this.btnCancelPopup.Click += new System.Windows.RoutedEventHandler(this.btnCancelPopup_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnDeleteSubtask = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Pop-ups\Edit_Subtask_Popup.xaml"
            this.btnDeleteSubtask.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Subtask_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

