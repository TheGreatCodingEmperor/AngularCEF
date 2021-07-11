using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace AngularCEF {
    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main (string[] args) {
            var settings = new CefSettings ();
            //Initialize CefSharp
            Cef.Initialize (settings, false, browserProcessHandler : null);

            CreateWebHostBuilder (args).Build ().RunAsync ();

            Application.SetHighDpiMode (HighDpiMode.SystemAware);
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);
            Application.Run (new Form1 ());

        }
        public static IWebHostBuilder CreateWebHostBuilder (string[] args) =>
            WebHost.CreateDefaultBuilder (args)
            .UseStartup<Startup> ().UseKestrel (options => {

                // HTTP 5000
                options.ListenLocalhost (5050);

                // HTTPS 5001
                options.ListenLocalhost (5051, builder => {
                    builder.UseHttps ();
                });
            });

    }
}