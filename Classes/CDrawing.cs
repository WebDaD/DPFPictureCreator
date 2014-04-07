using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QlockTwoCreator.Classes.Words;
using System.Drawing;
using QlockTwoCreator.Classes.Factories;
using QlockTwoCreator.Classes.Extensions;

namespace QlockTwoCreator.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public static class CDrawing
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="word"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="x_size"></param>
        /// <param name="y_size"></param>
        /// <param name="highlighted"></param>
        /// <param name="normal"></param>
        /// <param name="font"></param>
        /// <param name="time"></param>
        /// <returns>New X</returns>
        public static int Draw(Graphics g, Word word, int x, int y, float x_size, float y_size, Brush highlighted, Brush normal, Font font, DateTime time)
        {
            int hour = time.Hour;
            int minute = time.Minute;
            if (minute > 23) hour++;
            Brush paintbrush = normal;
            switch (word.State)
            {
                case WordState.On:
                    paintbrush = highlighted;
                    break;
                case WordState.Off:
                    paintbrush = normal;
                    break;
                case WordState.Hour:
                    if (hour.IsIn(word.Value, word.Value + 12)) paintbrush = highlighted;
                    else if (word.Value == 16 && hour.IsIn(5, 11, 17, 23)) paintbrush = highlighted;
                    else if (word.Value == 19 && hour.IsIn(9, 10, 21, 22)) paintbrush = highlighted;
                    else if (word.Value == 0 && hour == 24) paintbrush = highlighted;
                    else paintbrush = normal;
                    break;
                case WordState.Minute:
                    if (word.Value == 5 && (Between(minute, 2, 7) || Between(minute, 24, 28)||Between(minute, 34, 37)||Between(minute, 54, 57))) paintbrush = highlighted;
                    else if (word.Value == 10 && (Between(minute, 8, 13) || Between(minute, 48, 53))) paintbrush = highlighted;
                    else if (word.Value == 15 && (Between(minute, 14, 17) || Between(minute, 44, 47))) paintbrush = highlighted;
                    else if (word.Value == 20 && (Between(minute, 18, 23)||Between(minute, 38, 43))) paintbrush = highlighted;
                    else if (word.Value == 30 && Between(minute, 24, 37)) paintbrush = highlighted;
                    else if (word.Value == 45 && Between(minute, 44, 47)) paintbrush = highlighted;
                    else paintbrush = normal;
                    break;
                case WordState.Vor:
                    if (Between(minute, 24, 28)||Between(minute, 38, 43)||Between(minute, 48, 57))
                    {
                        paintbrush = highlighted;
                    }
                    else
                    {
                        paintbrush = normal;
                    }
                    break;
                case WordState.Nach:
                    if (Between(minute, 2, 7) || Between(minute, 8, 23) || Between(minute, 34, 37))
                    {
                        paintbrush = highlighted;
                    }
                    else
                    {
                        paintbrush = normal;
                    }
                    break;
                default:
                    paintbrush = normal;
                    break;
            }
            foreach (char c in word.Chars)
            {
                g.DrawString(c.ToString(), font, paintbrush, x * x_size, y * y_size);
                x++;
            }
            return x;
        }
        private static bool Between(int x, int min, int max)
        {
            if (x >= min && x <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
