using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * TODO :  
 */
namespace userInterface
{
    class OldOrderLayout : FlowLayoutPanel
    {
        private Button oldOrderButton = new Button();
        private CustomTextBox oldOrderTextBox;
        private Button displayResearchButton = new Button();

        public OldOrderLayout(EventHandler handler, string hintText) : base()
        {
            
            this.oldOrderButton.Click += new EventHandler(handler);
            this.displayResearchButton.Click += new EventHandler(this.DisplayResearch);
            this.oldOrderTextBox = new CustomTextBox(hintText);
            this.MountComponent();
        }

        public string GetOldOrderName()
        {
            string temp = this.oldOrderTextBox.Text;
            this.oldOrderTextBox.Text = "";
            return temp;
        }

        private void DisplayResearch(object sender, EventArgs e)
        {
            this.Controls.Remove(this.displayResearchButton);
            this.Controls.Add(this.oldOrderTextBox);
            this.Controls.Add(this.oldOrderButton);
        }

        private void MountComponent()
        {
            // Mouting Flow Layout 
            this.Controls.Add(this.displayResearchButton);
            this.Location = new System.Drawing.Point(25, 25);
            this.Size = new System.Drawing.Size(156, 67); 

            // Mount oldOrderTextBox
            this.oldOrderTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.oldOrderTextBox.Location = new System.Drawing.Point(3, 3);
            this.oldOrderTextBox.Name = "oldOrderName";
            this.oldOrderTextBox.Size = new System.Drawing.Size(152, 20);

            // Mount oldOrderButton
            this.oldOrderButton.Location = new System.Drawing.Point(3, 29);
            this.oldOrderButton.Name = "oldOrderButton";
            this.oldOrderButton.Size = new System.Drawing.Size(152, 35);
            this.oldOrderButton.Text = "Select the old order";
            this.oldOrderButton.UseVisualStyleBackColor = true;


            // Mount displayResearchButton
            this.displayResearchButton.Location = new System.Drawing.Point(34, 94);
            this.displayResearchButton.Size = new System.Drawing.Size(152, 35);
            this.displayResearchButton.Text = "Find an old order?";
            this.displayResearchButton.Name = "displayResearchButton";
            this.displayResearchButton.UseVisualStyleBackColor = true;
        }
    }
}
