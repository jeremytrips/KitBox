using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userInterface
{
    class ConfirmOrderLayout: System.Windows.Forms.Panel
    {
        UserDataLayout userDatalayout = new UserDataLayout();
        DisplayOrderLayout displayOrderLayout = new DisplayOrderLayout();
        System.Windows.Forms.Button continueButton = new System.Windows.Forms.Button();

        public List<List<object>> Data {set
            {
                this.displayOrderLayout.Data = value;
            }
        }

        public ConfirmOrderLayout() 
        {

            this.MountLayout();
            this.Controls.Add(userDatalayout);
        }

        private void SwitchLayout(object sender, EventArgs e)
        {
            this.displayOrderLayout.User = this.userDatalayout.SaveUserData();
            this.Controls.Remove(this.userDatalayout);
            this.Controls.Add(this.displayOrderLayout);
            this.displayOrderLayout.SendToBack();
            this.continueButton.Click -= this.SwitchLayout;
            this.continueButton.Click += new EventHandler(this.ConfirmOrder);
            this.continueButton.Text = "Continue and Pay";
        }

        private void ConfirmOrder(object sender, EventArgs e)
        {
            string message = "Please follow the instruction on the terminal.";
            string caption = "Kitbox payement";
            MessageBoxButtons button = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, caption, button);
            
            this.Parent.Controls.Remove(this);
        }

        private void MountLayout()
        {
            this.Controls.Add(this.continueButton);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(432, 580);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(161, 80);
            this.continueButton.TabIndex = 10;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new EventHandler(this.SwitchLayout);

            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new System.Drawing.Size(1024, 720);
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }
    }
}
