using MedWebView.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using MedWebView.Forms.Plugin.WindowsPhone;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(MedWebView.Forms.Plugin.Abstractions.MedWebViewControl), typeof(MedWebViewRenderer))]
namespace MedWebView.Forms.Plugin.WindowsPhone
{
    /// <summary>
    /// MedWebView Renderer
    /// </summary>
    public class MedWebViewRenderer //: TRender (replace with renderer type
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }
    }
}
