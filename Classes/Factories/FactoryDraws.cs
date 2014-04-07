using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace QlockTwoCreator.Classes.Factories
{
    public static class FactoryDraws
    {
        public static Brush GetBrush(Color color)
        {
            return new SolidBrush(color);
        }
        public static Font GetFont(string font, float size)
        {
            return new Font(font, size);
        }
        public static ImageFormat GetImageFormat(string format)
        {
            switch (format)
            {
                case "bmp": return ImageFormat.Bmp;
                case "gif": return ImageFormat.Gif;
                case "jpeg": return ImageFormat.Jpeg;
                case "png": return ImageFormat.Png;
                default: return ImageFormat.Jpeg;
            }
        }
    }
}
