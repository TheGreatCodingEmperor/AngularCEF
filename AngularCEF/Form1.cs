using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace AngularCEF
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///  嵌入式網頁
        /// </summary>
        private ChromiumWebBrowser _browser;
        /// <summary>
        /// Cef Js/CS 溝通介面
        /// </summary>
        private CefCustomObject _cefCustomObject;

        public Form1()
        {
            InitializeComponent();
            string filePath = Directory.GetCurrentDirectory() + "/Views/home.html";
            string angularPath = "http://localhost:5050";
            this._browser = new ChromiumWebBrowser (angularPath);
            this.Controls.Add (this._browser);

            // Cef js/cs 溝通介面註冊
            _cefCustomObject = new CefCustomObject (this._browser, this);
            this._browser.JavascriptObjectRepository.Settings.LegacyBindingEnabled = true;
            this._browser.JavascriptObjectRepository.Register ("cefCustomObject", _cefCustomObject);
        }
    }
}
