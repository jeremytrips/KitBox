using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userInterface
{
    class UserDataLayout: System.Windows.Forms.Panel
    {

        private Label label2;
        private TextBox nameInput;
        private Label label1;
        private TextBox textBox1;
        private Label label5;
        private CheckBox checkBox1;
        private TextBox phoneNumberInput;
        private Label label4;
        private TextBox addressInput;
        private Label label3;
        private List<TextBox> textinputs;

        User user;

        public UserDataLayout()
        {
            this.MountLayout();
            this.textinputs = new List<TextBox>
            {
                this.nameInput,
                this.phoneNumberInput,
                this.addressInput
            };
        }

        internal User User { get => user; set => user = value; }

        public bool SaveUserData()
        {
            bool i = true;
            foreach (TextBox tb in this.textinputs)
            {
                if (tb.Text == "")
                {
                    i = false;
                    break;
                }
            }
            if (i) {
                this.user = new User(this.nameInput.Text, this.addressInput.Text, this.phoneNumberInput.Text, this.checkBox1.Checked, this.textBox1.Text);
                return true;
            }
            return false;

        }

        private void MountLayout()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneNumberInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();

            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.phoneNumberInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label1);

            this.Location = new System.Drawing.Point(280, 110);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(464, 513);
            this.TabIndex = 0;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(196, 127);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(200, 20);
            this.nameInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please fill your personal data.";
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(196, 153);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(200, 20);
            this.addressInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // phoneNumberInput
            // 
            this.phoneNumberInput.Location = new System.Drawing.Point(196, 204);
            this.phoneNumberInput.Name = "phoneNumberInput";
            this.phoneNumberInput.Size = new System.Drawing.Size(200, 20);
            this.phoneNumberInput.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(179, 260);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Save order?";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Order name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;

        }
    }
}
