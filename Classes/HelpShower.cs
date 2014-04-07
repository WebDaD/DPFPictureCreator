using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QlockTwoCreator.Classes
{
    public static class HelpShower
    {
        public static void ShowHelp(string message)
        {
            MessageBox.Show(message, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
