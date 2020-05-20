﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInterface
{
    class RadioButtonLayout<T>: System.Windows.Forms.Panel
    {
        static int i;
        private List<System.Windows.Forms.RadioButton> radioButtonList = new List<System.Windows.Forms.RadioButton>();
        

        public RadioButtonLayout(int y , System.EventHandler handler, List<T> data): base()
        {
            RadioButtonLayout<T>.i += 1;
            this.MountLayout(y);
            this.CreateRadioButton(handler, data);
            
            
        }
        
        private void CreateRadioButton(EventHandler handler, List<T> data)
        {
            int index = 0;
            foreach(T i in data)
            {
                index += 1;
                System.Windows.Forms.RadioButton rb = new System.Windows.Forms.RadioButton();
                
                rb.Text = i.ToString();
                rb.Size = new System.Drawing.Size(50,20);
                rb.Location = new System.Drawing.Point(155, (index*20));
                rb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                rb.BackColor = System.Drawing.SystemColors.Control;
                rb.Name = i.ToString(); 
                rb.CheckedChanged += handler;
                this.radioButtonList.Add(rb);
                this.Controls.Add(rb);
                
               
            }
            this.radioButtonList[0].AutoCheck = true;
        }

        private void MountLayout(int y)
        {
         

            this.Location = new System.Drawing.Point(0, y);
            this.Size = new System.Drawing.Size(400, 100);
            this.BackColor = System.Drawing.SystemColors.Control;
          
            
                System.Windows.Forms.Label LabelHeight = new System.Windows.Forms.Label();
                LabelHeight.AutoSize = true;
                LabelHeight.Location = new System.Drawing.Point(34, 20);
                LabelHeight.Size = new System.Drawing.Size(108, 13);
                LabelHeight.Text = "Height of layer:";
                this.Controls.Add(LabelHeight);
            
            
            
                System.Windows.Forms.Label LabelCD = new System.Windows.Forms.Label();
                LabelCD.AutoSize = true;
                LabelCD.Location = new System.Drawing.Point(34, 40);
                LabelCD.Size = new System.Drawing.Size(108, 13);
                LabelCD.Text = "Color of the door:";
                this.Controls.Add(LabelCD);
            
            
                System.Windows.Forms.Label LabelCP = new System.Windows.Forms.Label();
                LabelCP.AutoSize = true;
                LabelCP.Location = new System.Drawing.Point(34, 60);
                LabelCP.Size = new System.Drawing.Size(108, 13);
                LabelCP.Text = "Color of the panels:";
                this.Controls.Add(LabelCP);
            
           
        }

        public string GetChecked()
        {
            foreach (System.Windows.Forms.RadioButton rb in this.radioButtonList)
            {
                if (rb.Checked)
                {
                    return rb.Text;
                }
            }
            return null;
        }

        internal void SetNullChecked()
        {
            throw new NotImplementedException();
        }
    }
}
