using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCustomTextBox
{
    public class CustomTextBox : TextBox
    {
        public Color FocusColor { get; set; }       

        public CustomTextBox()
        {
            this.Enter += CustomTextBox_Enter;
            this.Leave += CustomTextBox_Leave;           
        }

        private void CustomTextBox_Enter(object sender, EventArgs e)
        {
            BackColor = FocusColor;
        }

        private void CustomTextBox_Leave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }




        
    }
}
