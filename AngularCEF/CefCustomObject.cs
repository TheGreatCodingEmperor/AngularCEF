using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AngularCEF;
using CefSharp;
using CefSharp.WinForms;

namespace AngularCEF {
    /// <summary>
    /// Cef DotNet 對應 Html/js 介面
    /// </summary>
    class CefCustomObject {
        /// <summary>
        /// 內嵌 chrome 瀏覽器
        /// </summary>
        private readonly ChromiumWebBrowser _instanceBrowser;
        /// <summary>
        /// 乘載 Cef 的 winform
        /// </summary>
        private static Form1 _instanceMainForm = null;
        

        public CefCustomObject (ChromiumWebBrowser browser, Form1 form) {
            //設定 瀏覽器
            _instanceBrowser = browser;
            //設定 主form
            _instanceMainForm = form;
        }

        public string SayHello()
        {
            return "Hello World";
        }

        /// <summary>
        ///開啟瀏覽器 develope 視窗
        /// </summary>
        public void ShowDevTools () {
             _instanceBrowser.ShowDevTools ();
        }

        public void RefreshWindow(){
            _instanceBrowser.GetBrowser ().Reload ();
        }
    }
}