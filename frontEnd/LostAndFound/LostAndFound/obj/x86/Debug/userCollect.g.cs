﻿#pragma checksum "F:\学习资料\北大软微\研一下学期\软件实现技术\LOST_AND_FOUND\project\lost-and-found\frontEnd\LostAndFound\LostAndFound\userCollect.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B32E606D177915232050CA51D1A8147C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LostAndFound
{
    partial class userCollect : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
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

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class userCollect_obj2_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IuserCollect_Bindings
        {
            private global::LostAndFound.Models.Item dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::Windows.UI.Xaml.Controls.TextBlock obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3TextDisabled = false;
            private static bool isobj4TextDisabled = false;
            private static bool isobj5TextDisabled = false;

            private userCollect_obj2_BindingsTracking bindingsTracking;

            public userCollect_obj2_Bindings()
            {
                this.bindingsTracking = new userCollect_obj2_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 21 && columnNumber == 32)
                {
                    isobj3TextDisabled = true;
                }
                else if (lineNumber == 22 && columnNumber == 32)
                {
                    isobj4TextDisabled = true;
                }
                else if (lineNumber == 23 && columnNumber == 32)
                {
                    isobj5TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // userCollect.xaml line 14
                        this.obj2 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.ListViewItem)target);
                        break;
                    case 3: // userCollect.xaml line 21
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        this.bindingsTracking.RegisterTwoWayListener_3(this.obj3);
                        break;
                    case 4: // userCollect.xaml line 22
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        this.bindingsTracking.RegisterTwoWayListener_4(this.obj4);
                        break;
                    case 5: // userCollect.xaml line 23
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        this.bindingsTracking.RegisterTwoWayListener_5(this.obj5);
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj2.Target as global::Windows.UI.Xaml.Controls.ListViewItem).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::LostAndFound.Models.Item) item, 1 << phase);
            }

            public void Recycle()
            {
                this.bindingsTracking.ReleaseAllListeners();
            }

            // IuserCollect_Bindings

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
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::LostAndFound.Models.Item)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::LostAndFound.Models.Item obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Title(obj.Title, phase);
                        this.Update_Place(obj.Place, phase);
                        this.Update_CreateDatetime(obj.CreateDatetime, phase);
                    }
                }
            }
            private void Update_Title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // userCollect.xaml line 21
                    if (!isobj3TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                    }
                }
            }
            private void Update_Place(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // userCollect.xaml line 22
                    if (!isobj4TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                    }
                }
            }
            private void Update_CreateDatetime(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // userCollect.xaml line 23
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_3_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.Title = this.obj3.Text;
                    }
                }
            }
            private void UpdateTwoWay_4_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.Place = this.obj4.Text;
                    }
                }
            }
            private void UpdateTwoWay_5_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.CreateDatetime = this.obj5.Text;
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class userCollect_obj2_BindingsTracking
            {
                private global::System.WeakReference<userCollect_obj2_Bindings> weakRefToBindingObj; 

                public userCollect_obj2_BindingsTracking(userCollect_obj2_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<userCollect_obj2_Bindings>(obj);
                }

                public userCollect_obj2_Bindings TryGetBindingObject()
                {
                    userCollect_obj2_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    userCollect_obj2_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::LostAndFound.Models.Item obj = sender as global::LostAndFound.Models.Item;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_Title(obj.Title, DATA_CHANGED);
                                bindings.Update_Place(obj.Place, DATA_CHANGED);
                                bindings.Update_CreateDatetime(obj.CreateDatetime, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Title":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Title(obj.Title, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Place":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Place(obj.Place, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "CreateDatetime":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_CreateDatetime(obj.CreateDatetime, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::LostAndFound.Models.Item obj)
                {
                    userCollect_obj2_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
                public void RegisterTwoWayListener_3(global::Windows.UI.Xaml.Controls.TextBlock sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.TextBlock.TextProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_3_Text();
                        }
                    });
                }
                public void RegisterTwoWayListener_4(global::Windows.UI.Xaml.Controls.TextBlock sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.TextBlock.TextProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_4_Text();
                        }
                    });
                }
                public void RegisterTwoWayListener_5(global::Windows.UI.Xaml.Controls.TextBlock sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.TextBlock.TextProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_5_Text();
                        }
                    });
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class userCollect_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IuserCollect_Bindings
        {
            private global::LostAndFound.userCollect dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj6;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj6ItemsSourceDisabled = false;

            public userCollect_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 40 && columnNumber == 23)
                {
                    isobj6ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6: // userCollect.xaml line 39
                        this.obj6 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                throw new global::System.NotImplementedException();
            }

            public void Recycle()
            {
                throw new global::System.NotImplementedException();
            }

            // IuserCollect_Bindings

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

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::LostAndFound.userCollect)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::LostAndFound.userCollect obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::LostAndFound.Models.ItemViewModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_DefaultItems(obj.DefaultItems, phase);
                    }
                }
            }
            private void Update_ViewModel_DefaultItems(global::System.Collections.ObjectModel.ObservableCollection<global::LostAndFound.Models.Item> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // userCollect.xaml line 39
                    if (!isobj6ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj6, obj, null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 6: // userCollect.xaml line 39
                {
                    this.ItemGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)this.ItemGridView).ItemClick += this.GridView_ItemClick;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // userCollect.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    userCollect_obj1_Bindings bindings = new userCollect_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 2: // userCollect.xaml line 14
                {                    
                    global::Windows.UI.Xaml.Controls.ListViewItem element2 = (global::Windows.UI.Xaml.Controls.ListViewItem)target;
                    userCollect_obj2_Bindings bindings = new userCollect_obj2_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element2.DataContext);
                    element2.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element2, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element2, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

