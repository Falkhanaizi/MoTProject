﻿#pragma checksum "\\Mac\Home\Documents\Visual Studio 2015\Projects\MoTApp\MoTApp\TripMoreInfoPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0B4924E87B343A024DAC18520406649E"
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
    partial class TripMoreInfoPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class TripMoreInfoPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITripMoreInfoPage_Bindings
        {
            private global::MoTApp.TripMoreInfoPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;
            private global::Windows.UI.Xaml.Controls.TextBlock obj9;
            private global::Windows.UI.Xaml.Controls.TextBlock obj10;

            public TripMoreInfoPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 8:
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 9:
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 10:
                        this.obj10 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // ITripMoreInfoPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // TripMoreInfoPage_obj1_Bindings

            public void SetDataRoot(global::MoTApp.TripMoreInfoPage newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::MoTApp.TripMoreInfoPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_expandedStopsInfo(obj.expandedStopsInfo, phase);
                        this.Update_trip(obj.trip, phase);
                        this.Update_date(obj.date, phase);
                    }
                }
            }
            private void Update_expandedStopsInfo(global::System.Collections.Generic.List<global::System.String> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj7, obj, null);
                }
            }
            private void Update_trip(global::MoTApp.Trip obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_trip_totalCost(obj.totalCost, phase);
                        this.Update_trip_duration(obj.duration, phase);
                    }
                }
            }
            private void Update_trip_totalCost(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj, null);
                }
            }
            private void Update_date(global::System.DateTime obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj9, obj.ToString(), null);
                }
            }
            private void Update_trip_duration(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.RouteMap = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
                    #line 56 "\\Mac\Home\Documents\Visual Studio 2015\Projects\MoTApp\MoTApp\TripMoreInfoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Maps.MapControl)this.RouteMap).Loaded += this.RouteMap_Loaded;
                    #line default
                }
                break;
            case 3:
                {
                    this.BackBtn = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4:
                {
                    this.ReminderBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 116 "\\Mac\Home\Documents\Visual Studio 2015\Projects\MoTApp\MoTApp\TripMoreInfoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ReminderBtn).Click += this.ReminderBtn_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.SaveBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 123 "\\Mac\Home\Documents\Visual Studio 2015\Projects\MoTApp\MoTApp\TripMoreInfoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SaveBtn).Click += this.SaveBtn_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.QuitBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 130 "\\Mac\Home\Documents\Visual Studio 2015\Projects\MoTApp\MoTApp\TripMoreInfoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.QuitBtn).Click += this.QuitBtn_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.StopsList = (global::Windows.UI.Xaml.Controls.ListView)(target);
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    TripMoreInfoPage_obj1_Bindings bindings = new TripMoreInfoPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

