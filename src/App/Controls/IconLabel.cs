﻿using Xamarin.Forms;

namespace Bit.App.Controls
{
    public class IconLabel : Label
    {
        public IconLabel()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    FontFamily = "Bitwarden_icon_font_v1";
                    break;
                case Device.Android:
                    FontFamily = "Bitwarden_icon_font_v1.ttf#Bitwarden_icon_font_v1";
                    break;
            }
        }
    }
}