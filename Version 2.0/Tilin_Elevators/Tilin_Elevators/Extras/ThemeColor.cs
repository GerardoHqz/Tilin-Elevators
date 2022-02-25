﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators_Tilin.Extras
{
    class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecundaryColor { get; set; }
        public static List<string> ColorList = new List<string>() 
        { 
            "#011f4b",
            "#03396c",
            "#005b96",
            "#034e9e",
            "#145ea8",
            "#257aba"
            
        };
        //metodo para cambiar el brillo del color
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
