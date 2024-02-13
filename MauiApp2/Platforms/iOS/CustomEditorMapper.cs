using CoreGraphics;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;

namespace MauiApp2.Platforms
{
    public static class CustomEditorMapper
    {
        public static void Map(IElementHandler handler, IElement view)
        {
            if (view is CustomEditor)
            {
                var casted = (EditorHandler)handler;
                var viewData = (CustomEditor)view;
                casted.PlatformView.ScrollEnabled = true;
                casted.PlatformView.Layer.BorderColor = UIColor.FromRGB(227, 227, 227).CGColor;
                casted.PlatformView.Layer.BorderWidth = 1.3f;
                casted.PlatformView.Layer.CornerRadius = 8f;
            }
        }
    }
}
