using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QlockTwoCreator.Classes.Factories;
using QlockTwoCreator.Classes.Words;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QlockTwoCreator.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class Main
    {
        //props
        private List<DateTime> times;
        private int factor;

        private List<List<Word>> field;

        private int resolution_x;
        private int resolution_y;

        private float x_space;
        private float y_space;

        private Color bColor;
        private Color hColor;
        private Color nColor;

        private Brush background;
        private Brush highlighted;
        private Brush normal;

        private string fontFamily;
        private float fontSize;
        private Font font;

        private string filepath;
        private ImageFormat format;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="factor"></param>
        /// <param name="resolution_x"></param>
        /// <param name="resolution_y"></param>
        /// <param name="backgroundColor"></param>
        /// <param name="highlightColor"></param>
        /// <param name="normalColor"></param>
        /// <param name="fontfamily"></param>
        /// <param name="filepath"></param>
        /// <param name="format"></param>
        public Main(int factor, int resolution_x, int resolution_y, Color backgroundColor, Color highlightColor, Color normalColor, string fontfamily, string filepath, string format, string secret)
        {
            this.factor = factor;

            this.times = FactoryTimes.GetTimes(this.factor);
            this.field = FactoryFields.GetField(secret);

            this.resolution_x = resolution_x;
            this.resolution_y = resolution_y;

            this.x_space = getXSpace();
            this.y_space = getYSpace();

            this.bColor = backgroundColor;
            this.hColor = highlightColor;
            this.nColor = normalColor;

            this.background = FactoryDraws.GetBrush(bColor);
            this.highlighted = FactoryDraws.GetBrush(hColor);
            this.normal = FactoryDraws.GetBrush(nColor);

            this.fontFamily = fontfamily;
            this.fontSize = getFontSize();
            this.font = FactoryDraws.GetFont(fontfamily, fontSize);

            this.filepath = filepath;
            this.format = FactoryDraws.GetImageFormat(format);

            createPath();
        }
        /// <summary>
        /// 
        /// </summary>
        public void CreatePictures(ProgressBar pg)
        {
            int y;
            int x;
            pg.Minimum = 0;
            pg.Maximum = times.Count;
            pg.Step = 1;
            foreach (DateTime t in times)
            {
                Bitmap bitmap = new Bitmap(resolution_x, resolution_y, PixelFormat.Format32bppArgb);
                Graphics g = Graphics.FromImage(bitmap);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = new Rectangle(0, 0, resolution_x, resolution_y);
                g.FillRectangle(background, rect);
                y = 0;
                foreach (List<Word> row in field)
                {
                    x = 0;
                    foreach (Word word in row)
                    {
                        x = CDrawing.Draw(g, word, x, y, x_space, y_space, highlighted,normal, font, t);
                    }
                    y++;
                }
                string hs = t.Hour.ToString();
                if (t.Hour < 10) hs = "0" + hs;
                string ms = t.Minute.ToString();
                if (t.Minute < 10) ms = "0" + ms;
                bitmap.Save(filepath + "\\_" + hs + ms + "." + format.ToString().ToLower(), format);
                pg.PerformStep();
                bitmap.Dispose();
                bitmap = null;
                GC.Collect();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private float getYSpace()
        {
            return resolution_y / field.Count;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private float getXSpace()
        {
            return resolution_x / getCols();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int getCols()
        {
            int cols = 0;
            foreach (Word w in field[0])
            {
                cols += w.Chars.Count;
            }
            return cols;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private float getFontSize()
        {
            return y_space - (y_space / 10) - (y_space / 10);
        }
        /// <summary>
        /// 
        /// </summary>
        private void createPath()
        {
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
        }
    }
}
