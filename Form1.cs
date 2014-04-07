using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using QlockTwoCreator.Classes;
//By Dominik Sigmund, 2011 WebDaD.eu
namespace QlockTwoCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cb_Format.Items.Add(ImageFormat.Bmp.ToString().ToLower());
            cb_Format.Items.Add(ImageFormat.Gif.ToString().ToLower());
            cb_Format.Items.Add(ImageFormat.Jpeg.ToString().ToLower());
            cb_Format.Items.Add(ImageFormat.Png.ToString().ToLower());
            cb_Format.SelectedIndex = 2;
        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_path.Text))
            {
                MessageBox.Show("Please enter a Path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(txt_Font.Text))
            {
                MessageBox.Show("Please enter a Font!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Main m = new Main((int)nud_Factor.Value, (int)nud_Res_X.Value, (int)nud_Res_Y.Value, lb_BG.BackColor, lb_HL.BackColor, lb_Normal.BackColor, txt_Font.Text, txt_path.Text, cb_Format.SelectedText, txt_Secret.Text);
                m.CreatePictures(pg_Bar);
                MessageBox.Show("All Went good :-)", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_BG_Click(object sender, EventArgs e)
        {
            cd_BG.ShowDialog();
            lb_BG.BackColor = cd_BG.Color;
        }

        private void lb_HL_Click(object sender, EventArgs e)
        {
            cd_HL.ShowDialog();
            lb_HL.BackColor = cd_HL.Color;
        }

        private void lb_Normal_Click(object sender, EventArgs e)
        {
            cd_Normal.ShowDialog();
            lb_Normal.BackColor = cd_Normal.Color;
        }

        private void btn_Folder_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog();
            txt_path.Text = fbd.SelectedPath;
        }

        private void btn_Font_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            txt_Font.Text = fontDialog.Font.FontFamily.Name;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_path.Text = "";
            cb_Format.SelectedIndex = 2;
            nud_Res_X.Value = 800;
            nud_Res_Y.Value = 600;
            nud_Factor.Value = 1;
            txt_Font.Text = "Arial";
            txt_Secret.Text = "DOMINIKSIGMUNDWD";
            lb_BG.BackColor = Color.Black;
            lb_HL.BackColor = Color.White;
            lb_Normal.BackColor = Color.Silver;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Help().ShowDialog();
        }

        private void dPFHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DPFHelp().ShowDialog();
        }

        private void label7_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help("Select a Path where all the Pictures will be saved to.");
        }

        private void label8_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help("What Format the Images should have.");
        }

        private void label2_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help("The Width of the Pictures.");
        }

        private void label3_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help("The height of the Pictures.");
        }

        private void label9_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help("Time in minutes, shows how long a picture will be displayed before changing to the next.\nCurrently disabled.");
        }

        private void label4_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help("Background Color of the Pictures.");
        }

        private void label5_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help("Color of the Words which show the current time.");
        }

        private void label6_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help("Color of all inactive Words.");
        }

        private void label11_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help("Name of the Font used.");
        }

        private void label12_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help("A Word, hidden in the Clock.\nIt must have exactly 16 Characters, no Numbers.");
        }

        private void txt_path_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            label7_HelpRequested(sender, hlpevent);
        }

        private void btn_Folder_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            label7_HelpRequested(sender, hlpevent);
        }

        private void cb_Format_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            label8_HelpRequested(sender, hlpevent);
        }

        private void nud_Res_X_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            label2_HelpRequested(sender, hlpevent);
        }

        private void nud_Res_Y_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            label3_HelpRequested(sender, hlpevent);
        }

        private void nud_Factor_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            label9_HelpRequested(sender, hlpevent);
        }

        private void lb_BG_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            label4_HelpRequested(sender, hlpevent);
        }

        private void lb_HL_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            label5_HelpRequested(sender, hlpevent);
        }

        private void lb_Normal_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            label6_HelpRequested(sender, hlpevent);
        }

        private void txt_Font_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            label11_HelpRequested(sender, hlpevent);
        }

        private void btn_Font_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            label11_HelpRequested(sender, hlpevent);
        }

        private void txt_Secret_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            label12_HelpRequested(sender, hlpevent);
        }

        private void pg_Bar_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help("A Progressbar. It will display the Creation of the Pictures.");
        }

        private void btn_Exit_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help("Exit the Software.\nBest clicked after creating the Pictures.");
        }

        private void btn_Go_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help("Start the Magic...\nHave you Checked your Settings?");
        }
        private void Help(string message)
        {
            HelpShower.ShowHelp(message);
        }
    }
}
