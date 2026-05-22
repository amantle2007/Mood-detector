using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoodDetector
{
    public partial class TfrmMood : Form
    {
        public TfrmMood()
        {
            InitializeComponent();
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            switch (cmbMood.Text)  
            {
                case "Happy": pnlMood.BackColor = ColorTranslator.FromHtml("#ffba08");
                              MessageBox.Show("Your happiness is contagious! Keep shining bright today!");
                              break;

                case "Sad": pnlMood.BackColor = ColorTranslator.FromHtml("#0077b6");
                            MessageBox.Show("Tomorrow will be better!");
                            break;

                case "Tired": pnlMood.BackColor = ColorTranslator.FromHtml("#bb9457");
                              MessageBox.Show("You've been working so hard give yourself permission to rest!");
                              break;

                case "Bored": pnlMood.BackColor = ColorTranslator.FromHtml("#7f5539");
                              MessageBox.Show("If you're bored, that just means your brain is resting up for its next brilliant idea.");
                               break;

                case "Angry": pnlMood.BackColor = ColorTranslator.FromHtml("#d00000");
                              MessageBox.Show("I know you're dealing with a lot of frustrating stuff right now, and it's totally valid to be mad");
                              break;

                case "Loving": pnlMood.BackColor = ColorTranslator.FromHtml("#f4978e");
                               MessageBox.Show("Love is in the air huh!!");
                               break;

                case "Jealous": pnlMood.BackColor = ColorTranslator.FromHtml("#2b9348");
                                MessageBox.Show("Just a little reminder that you are so incredibly special, NO ONE can ever be you");
                                break;
                     
            }
        }
    }
}
