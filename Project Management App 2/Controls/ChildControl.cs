using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Project_Management_App_2.Controls
{
    public class ChildControl : UserControl
    {
        //Metodele care realizaeză relatia parent-child dintre usercontrol si mainwindow
        public static readonly RoutedEvent ParentChildEvent = EventManager.RegisterRoutedEvent("ParentChild", 
            RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(ChildControl));

        //Permite adăugarea și eliminarea gestionarilor de evenimente pentru a gestiona evenimentul personalizat
        public event RoutedEventHandler ParentChild
        {
            add { AddHandler(ParentChildEvent, value); }
            remove { RemoveHandler(ParentChildEvent, value); }
        }
    }
}
