using System.Drawing;

namespace MassData.Classes
{
    internal static class CustomColors
    {
        private static readonly Color primaryColor = Color.FromArgb(69,90,100);
        private static readonly Color primaryLightColor = Color.FromArgb(113, 135, 146);
        private static readonly Color primaryDarkColor = Color.FromArgb(28, 49, 58);
        private static readonly Color secondaryColor = Color.FromArgb(236, 239, 241);
        private static readonly Color secondaryLightColor = Color.FromArgb(255, 255, 255);
        private static readonly Color secondaryDarkColor = Color.FromArgb(186, 189, 190);
        private static readonly Color primaryTextColor = Color.FromArgb(255, 255, 255);
        private static readonly Color secondaryTextColor = Color.FromArgb(0, 0, 0);
        private static readonly Color closeOrErrorColor = Color.FromArgb(252, 32, 3);

        internal static Color PrimaryColor
        {
            get { return primaryColor; }
        }

        internal static Color PrimaryLightColor
        {
            get { return primaryLightColor; }
        }

        internal static Color PrimaryDarkColor
        {
            get { return primaryDarkColor; }
        }

        internal static Color SecondaryColor
        {
            get { return secondaryColor; }
        }

        internal static Color SecondaryLightColor
        {
            get { return secondaryLightColor; }
        }

        internal static Color SecondaryDarkColor
        {
            get { return secondaryDarkColor; }
        }

        internal static Color PrimaryTextColor
        {
            get { return primaryTextColor; }
        }

        internal static Color SecondaryTextColor
        {
            get { return secondaryTextColor; }
        }

        internal static Color CloseOrErrorColor
        {
            get { return closeOrErrorColor; }
        }

    }
}
