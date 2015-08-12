using MedWebView.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using MedWebView.Forms.Plugin.Android;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MedWebView.Forms.Plugin.Abstractions.MedWebViewControl), typeof(MedWebViewRenderer))]
namespace MedWebView.Forms.Plugin.Android
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