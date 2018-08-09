using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoViews2
{
    public partial class CambiarColor : ContentPage
    {
        public CambiarColor()
        {
            InitializeComponent();
        }
        void colores(object sender,Xamarin.Forms.ValueChangedEventArgs e)
        {
            var rojo = sldRojo.Value;
            var azul = sldAzul.Value;
            var verde = sldVerde.Value;
            Color bgColor = new Color(rojo, verde, azul);
            boxColor.BackgroundColor = bgColor;
            lbDisplay.Text = ColorToHex(bgColor);
        }
        private string ColorToHex(Color color)
        {
            int rojo = (int)(color.R * 255);
            int verde = (int)(color.G * 255);
            int azul= (int)(color.B * 255);
            int alpha = (int)(color.A * 255);
            return $"#{rojo:X2}{verde:X2}{azul:X2}{alpha:X2}";

        }
    }
}
