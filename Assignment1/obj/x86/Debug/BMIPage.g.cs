﻿#pragma checksum "C:\Users\Leoval Cabato\OneDrive\Documents\Fall2023 Yr2\CSTP 2104 - Windows Interactive App Prog (Xing)\Assignment1\Assignment1\BMIPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "39D2381F0EB47044A51CFC8E5B20BF603BB822B64A3BC0F8D0F812AF179E340C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment1
{
    partial class BMIPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // BMIPage.xaml line 13
                {
                    this.txtHeight = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // BMIPage.xaml line 14
                {
                    this.txtWeight = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // BMIPage.xaml line 15
                {
                    this.txtBMIResult = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // BMIPage.xaml line 18
                {
                    this.heightCM = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // BMIPage.xaml line 19
                {
                    this.weightKG = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // BMIPage.xaml line 22
                {
                    this.btnCalculateBMI = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCalculateBMI).Click += this.btnCalculateBMI_Click;
                }
                break;
            case 8: // BMIPage.xaml line 23
                {
                    this.btnHome = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnHome).Click += this.btnHome_Click;
                }
                break;
            case 9: // BMIPage.xaml line 24
                {
                    this.bmiResult = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

