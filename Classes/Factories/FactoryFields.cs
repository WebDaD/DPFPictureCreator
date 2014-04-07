using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QlockTwoCreator.Classes.Words;

namespace QlockTwoCreator.Classes.Factories
{
    /// <summary>
    /// 
    /// </summary>
    public static class FactoryFields
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<List<Word>> GetField(string secret)
        {
            List<List<Word>> field = new List<List<Word>>();
            for (int i = 0; i < 10; i++)
            {
                List<Word> row = new List<Word>();
                switch (i)
                {
                    case 0:
                        row.Add(new Word(new List<char>() { 'E', 'S' }, WordState.On));
                        row.Add(new Word(new List<char>() { secret[0] }, WordState.Off));
                        row.Add(new Word(new List<char>() { 'I', 'S', 'T' }, WordState.On));
                        row.Add(new Word(new List<char>() { secret[1] }, WordState.Off));
                        row.Add(new Word(new List<char>() { 'F', 'Ü', 'N', 'F' }, WordState.Minute, 5));
                        break;
                    case 1:
                        row.Add(new Word(new List<char>() { 'Z', 'E', 'H', 'N' }, WordState.Minute, 10));
                        row.Add(new Word(new List<char>() { 'Z', 'W', 'A', 'N', 'Z', 'I', 'G' }, WordState.Minute, 20));
                        break;
                    case 2:
                        row.Add(new Word(new List<char>() { 'D', 'R', 'E', 'I' }, WordState.Minute, 45));
                        row.Add(new Word(new List<char>() { 'V', 'I', 'E', 'R', 'T', 'E', 'L' }, WordState.Minute, 15));
                        break;
                    case 3:
                        row.Add(new Word(new List<char>() { 'V', 'O', 'R' }, WordState.Vor));
                        row.Add(new Word(new List<char>() { secret[2], secret[3], secret[4], secret[5] }, WordState.Off));
                        row.Add(new Word(new List<char>() { 'N', 'A', 'C', 'H' }, WordState.Nach));
                        break;
                    case 4:
                        row.Add(new Word(new List<char>() { 'H', 'A', 'L', 'B' }, WordState.Minute, 30));
                        row.Add(new Word(new List<char>() { secret[6] }, WordState.Off));
                        row.Add(new Word(new List<char>() { 'E', 'L' }, WordState.Hour, 11));
                        row.Add(new Word(new List<char>() { 'F' }, WordState.Hour, 16));
                        row.Add(new Word(new List<char>() { 'Ü', 'N', 'F' }, WordState.Hour, 5));
                        break;
                    case 5:
                        row.Add(new Word(new List<char>() { 'E', 'I', 'N', 'S' }, WordState.Hour, 1));
                        row.Add(new Word(new List<char>() { secret[7], secret[8], secret[9] }, WordState.Off));
                        row.Add(new Word(new List<char>() { 'Z', 'W', 'E', 'I' }, WordState.Hour, 2));
                        break;
                    case 6:
                        row.Add(new Word(new List<char>() { 'D', 'R', 'E', 'I' }, WordState.Hour, 3));
                        row.Add(new Word(new List<char>() { secret[10], secret[11], secret[12] }, WordState.Off));
                        row.Add(new Word(new List<char>() { 'V', 'I', 'E', 'R' }, WordState.Hour, 4));
                        break;
                    case 7:
                        row.Add(new Word(new List<char>() { 'S', 'E', 'C', 'H', 'S' }, WordState.Hour, 6));
                        row.Add(new Word(new List<char>() { secret[13], secret[14] }, WordState.Off));
                        row.Add(new Word(new List<char>() { 'A', 'C', 'H', 'T' }, WordState.Hour, 8));
                        break;
                    case 8:
                        row.Add(new Word(new List<char>() { 'S', 'I', 'E', 'B', 'E', 'N' }, WordState.Hour, 7));
                        row.Add(new Word(new List<char>() { 'Z', 'W', 'Ö', 'L', 'F' }, WordState.Hour, 0));
                        break;
                    case 9:
                        row.Add(new Word(new List<char>() { 'Z', 'E', 'H' }, WordState.Hour, 10));
                        row.Add(new Word(new List<char>() { 'N' }, WordState.Hour, 19));
                        row.Add(new Word(new List<char>() { 'E', 'U', 'N' }, WordState.Hour, 9));
                        row.Add(new Word(new List<char>() { secret[15] }, WordState.Off));
                        row.Add(new Word(new List<char>() { 'U', 'H', 'R' }, WordState.On));
                        break;
                    default:
                        break;
                }
                field.Add(row);
            }
            return field;
        }
    }
}
