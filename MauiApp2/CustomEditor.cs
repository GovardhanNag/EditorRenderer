using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2
{
    public class CustomEditor : Editor
    {
        public static readonly BindableProperty RoundedBorderProperty =
            BindableProperty.Create(nameof(IsRoundedBorder), typeof(bool), typeof(CustomEditor), true);
        public bool IsRoundedBorder
        {
            get { return (bool)GetValue(RoundedBorderProperty); }
            set { SetValue(RoundedBorderProperty, value); }
        }
    }
}
