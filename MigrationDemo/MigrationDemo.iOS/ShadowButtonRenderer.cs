using MigrationDemo;
using MigrationDemo.iOS;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

[assembly: ExportRenderer(typeof(ShadowButton), typeof(ShadowButtonRenderer))]
namespace MigrationDemo.iOS
{
    public class ShadowButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                // Cleanup
            }

            if (e.NewElement != null)
            {
                Control.TitleShadowOffset = new CoreGraphics.CGSize(1, 1);
                Control.SetTitleShadowColor(Color.Black.ToUIColor(), UIKit.UIControlState.Normal);
            }
        }
    }
}