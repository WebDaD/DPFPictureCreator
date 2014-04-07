using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QlockTwoCreator.Classes.Words
{
    /// <summary>
    /// 
    /// </summary>
    public class Word
    {
        private WordState state;
        public WordState State { get { return state; } }

        private List<char> chars;
        public List<char> Chars { get { return chars; } }

        private int value;
        public int Value { get { return value; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chars"></param>
        /// <param name="state"></param>
        public Word(List<char> chars, WordState state)
        {
            this.chars = chars;
            this.state = state;
            this.value = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chars"></param>
        /// <param name="state"></param>
        /// <param name="value"></param>
        public Word(List<char> chars, WordState state, int value)
            : this(chars, state)
        {
            this.value = value;
        }
    }
}
