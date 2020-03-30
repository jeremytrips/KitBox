using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    class CustomTextBox: System.Windows.Forms.TextBox
    {
        private string HintText;

        public CustomTextBox(string hintText): base()
        {
            this.HintText = hintText;
            this.Text = hintText;
            this.GotFocus += new EventHandler(this.RemoveText);
            this.LostFocus += new EventHandler(this.SetText);
        }

        private void RemoveText(object sender, EventArgs e)
        {
            if(this.Text == this.HintText)
            {
                this.Text = "";
            }
        }

        private void SetText(object sender, EventArgs e)
        {
            if (this.Text == "")
            {
                this.Text = this.HintText;
            }
        }

    }
}
