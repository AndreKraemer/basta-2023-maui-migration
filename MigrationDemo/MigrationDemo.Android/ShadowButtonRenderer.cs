using Android.Content;
using MigrationDemo;
using MigrationDemo.Droid;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

[assembly: ExportRenderer(typeof(ShadowButton), typeof(ShadowButtonRenderer))]
namespace MigrationDemo.Droid
{
    public class ShadowButtonRenderer : Platform.Android.AppCompat.ButtonRenderer
    {
        public ShadowButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                // Cleanup
            }

            if (e.NewElement != null)
            {
                Control.SetShadowLayer(5, 3, 3, Color.Black.ToAndroid());
            }
        }
    }
}