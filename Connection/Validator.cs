using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace VideoClub
{
    public static class Validator
    {

        private static string error = "Error Message";

        public static string Error
        {
            get { return error; }
            set { error = value; }
        }
        public static bool Ispresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    MessageBox.Show(textBox.Tag +  " " +  "Is required ", error);
                    textBox.Focus();
                    return false;
                }

            }
            return true;
        }

        public static bool Isinteger(TextBox textbox)
        {
            try
            {
                Convert.ToInt32(textbox.Text);
                return true;

            }
            catch (FormatException exception)
            {

                MessageBox.Show(textbox.Tag + exception.Message + "\n" + "\n" + "Integer number only", error);
                return false;
            }
        }
        public static bool IsWithinRange(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.NumericUpDown")
            {
                NumericUpDown numericUpDown = (NumericUpDown)control;
                int val = (int)numericUpDown.Value;
                int min = (int)numericUpDown.Minimum;
                int max = (int)numericUpDown.Maximum;
                if (val < min || val > max)
                {
                    MessageBox.Show(numericUpDown.Tag + " " + "the number must be between " + min.ToString() + " and " + max.ToString(), error);
                    return false;
                }
                
            }
            return true;

        }
    }
}
