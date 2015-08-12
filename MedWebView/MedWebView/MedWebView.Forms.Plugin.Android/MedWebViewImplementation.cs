using MedWebView.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using MedWebView.Forms.Plugin.Android;
using Xamarin.Forms.Platform.Android;
using MedWebView.Forms.Plugin.Abstractions;

[assembly: ExportRenderer(typeof(MedWebViewControl), typeof(MedWebViewRenderer))]
namespace MedWebView.Forms.Plugin.Android
{
    /// <summary>
    /// MedWebView Renderer
    /// </summary>
    public class MedWebViewRenderer : Xamarin.Forms.Platform.Android.WebViewRenderer
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }

        protected MedWebView MedWebViewElement
        {
            get { return Element as MedWebView; }
        }

        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                HideSavePasswordPrompt();

                DisableBounceEffect();
            }
        }

        private static void DisableBounceEffect()
        {
            //disabled bounce effect
            Control.OverScrollMode = OverScrollMode.Never;
            Control.HorizontalScrollBarEnabled = false;
            Control.SetHorizontalScrollbarOverlay(false);
        }

        protected virtual void HideSavePasswordPrompt()
        {
            if ((int)Build.VERSION.SdkInt <= 18)
            {
#pragma warning disable 618
                Control.Settings.SavePassword = false;
#pragma warning restore 618
            }
        }


    }
}