using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Text.Method;
using Android.Views;
using MauiApp2.Platforms.Android;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = Android.Graphics.Color;

namespace MauiApp2.Platforms
{
    public static class CustomEditorMapper
    {
        public static void Map(IElementHandler handler, IElement view)
        {
            if(view is CustomEditor)
            {
                var casted = (EditorHandler)handler;
                var viewData = (CustomEditor)view;
                var gd = new GradientDrawable();
                casted.PlatformView.OverScrollMode = OverScrollMode.Always;
                casted.PlatformView.ScrollBarStyle = ScrollbarStyles.InsideInset;
                casted.PlatformView.SetOnTouchListener(new DroidTouchListener());


                casted.PlatformView.VerticalScrollBarEnabled = true;
                casted.PlatformView.MovementMethod = ScrollingMovementMethod.Instance;
                gd.SetCornerRadius(10);
                gd.SetStroke(2, Color.Black);
                if(viewData.IsRoundedBorder)
                    casted.PlatformView.Background = gd;
            }
        }
    }
}
