using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    class RadioButtonLayout: System.Windows.Forms.Panel
    {
        private List<System.Windows.Forms.RadioButton> radioButtonList = new List<System.Windows.Forms.RadioButton>();

        public RadioButtonLayout(System.EventHandler handler, List<int> data): base()
        {
            this.MountLayout();
            this.CreateRadioButton(handler, data);
        }

        private void CreateRadioButton(EventHandler handler, List<int> data)
        {
            int index = 0;
            foreach(int i in data)
            {
                Console.WriteLine(i);
                index += 1;
                System.Windows.Forms.RadioButton rb = new System.Windows.Forms.RadioButton();
                rb.Text = i.ToString();
                rb.Size = new System.Drawing.Size(50,20);
                rb.Location = new System.Drawing.Point(0, 5+(index*20));
                rb.Name = i.ToString(); ;
                rb.CheckedChanged += handler;
                this.radioButtonList.Add(rb);
                this.Controls.Add(rb);
            }
        }

        private void MountLayout()
        {
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(400, 150);
            this.BackColor = System.Drawing.Color.Yellow;
        }

        internal int GetHeight()
        {
            foreach(System.Windows.Forms.RadioButton rb in this.radioButtonList)
            {
                if (rb.Checked)
                {
                    return Int16.Parse(rb.Text);
                }
            }
            return -1;
        }
    }
}
