﻿#pragma checksum "\\mac\home\documents\visual studio 2015\Projects\MoTApp\MoTApp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "688F18D1AFFBBDA607EA0A407980E531"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoTApp
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.WelcomeLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.RecMap = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                    #line 56 "\\mac\home\documents\visual studio 2015\Projects\MoTApp\MoTApp\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Rectangle)this.RecMap).Tapped += this.RecMap_Tapped;
                    #line default
                }
                break;
            case 3:
                {
                    this.RecTripPlanner = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                    #line 70 "\\mac\home\documents\visual studio 2015\Projects\MoTApp\MoTApp\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Rectangle)this.RecTripPlanner).Tapped += this.RecTripPlanner_Tapped;
                    #line default
                }
                break;
            case 4:
                {
                    this.RecSavedTrips = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                    #line 84 "\\mac\home\documents\visual studio 2015\Projects\MoTApp\MoTApp\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Rectangle)this.RecSavedTrips).Tapped += this.RecSavedTrips_Tapped;
                    #line default
                }
                break;
            case 5:
                {
                    this.RecNews = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                    #line 98 "\\mac\home\documents\visual studio 2015\Projects\MoTApp\MoTApp\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Rectangle)this.RecNews).Tapped += this.RecNews_Tapped;
                    #line default
                }
                break;
            case 6:
                {
                    this.BusPic = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7:
                {
                    this.FeedbackLogo = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 34 "\\mac\home\documents\visual studio 2015\Projects\MoTApp\MoTApp\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.FeedbackLogo).Tapped += this.FeedbackLogo_Tapped;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
