#pragma checksum "..\..\..\Pop-ups\Add_Subtask_Screen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4CB97C41AF2F1EC080700E21AC420792A8F939CD3DD6E2C852F42ACC7C49AD9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Project_Management_App_2.Windows;
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


namespace Project_Management_App_2.Windows {
    
    
    /// <summary>
    /// Add_Subtask_Screen
    /// </summary>
    public partial class Add_Subtask_Screen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Pop-ups\Add_Subtask_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack_CurrentTask;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pop-ups\Add_Subtask_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSubtaskName;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pop-ups\Add_Subtask_Screen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveProject;
        
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
            System.Uri resourceLocater = new System.Uri("/Project Management App 2;component/pop-ups/add_subtask_screen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pop-ups\Add_Subtask_Screen.xaml"
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
            this.btnBack_CurrentTask = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Pop-ups\Add_Subtask_Screen.xaml"
            this.btnBack_CurrentTask.Click += new System.Windows.RoutedEventHandler(this.btnBack_CurrentTask_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtSubtaskName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnSaveProject = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\Pop-ups\Add_Subtask_Screen.xaml"
            this.btnSaveProject.Click += new System.Windows.RoutedEventHandler(this.btnSaveSubtask_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

