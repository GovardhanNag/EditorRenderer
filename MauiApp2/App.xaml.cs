using Microsoft.Maui.Platform;
namespace MauiApp2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(IView.Background), (handler, view) =>
            {
            if (view is CustomEntry)
            {
#if ANDROID
                float[] outerRadii = { 10, 10, 10, 10, 10, 10, 10, 10 };  
                Android.Graphics.Drawables.Shapes.RoundRectShape roundRectShape = new Android.Graphics.Drawables.Shapes.RoundRectShape(outerRadii, null, null);  
                var shape = new Android.Graphics.Drawables.ShapeDrawable(roundRectShape);  
                shape.Paint.Color = Android.Graphics.Color.Gray;  
                shape.Paint.StrokeWidth = 3;  
                shape.Paint.SetStyle(Android.Graphics.Paint.Style.Stroke);  
                handler.PlatformView.Background=shape; 
#elif IOS
                    handler.PlatformView.Layer.BorderColor = UIKit.UIColor.Gray.CGColor;
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.RoundedRect;
#endif
            }
            });

            MainPage = new AppShell();
        }
    }
}
