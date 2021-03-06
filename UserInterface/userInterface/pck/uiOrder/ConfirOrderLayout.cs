﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userInterface
{
    class ConfirmOrderLayout: System.Windows.Forms.Panel
    {
        private UserDataLayout userDatalayout = new UserDataLayout();
        private DisplayOrderLayout displayOrderLayout = new DisplayOrderLayout();
        private Button continueButton = new Button();
        private Button backButton = new Button();
        private ClientOrder order;
        private Action resetApp;
        private EventHandler backAction;

        public ClientOrder Order
        {
            set
            {
                order = value;
                Console.WriteLine(order.ClearedBill.Count());
                //foreach (KeyValuePair<string, int> a in order.ClearedBill)
                //{
                //    Console.WriteLine(a.Key);
                //}
            }
        }

        public ConfirmOrderLayout(Action resetApp, EventHandler backAction)
        { 
            this.resetApp = resetApp;
            this.backAction = backAction;
            this.MountLayout();
            this.Controls.Add(userDatalayout);
        }

        private void SwitchLayout(object sender, EventArgs e)
        {
            if (this.userDatalayout.SaveUserData())
            {
                this.displayOrderLayout = new DisplayOrderLayout();
                this.order.User = this.userDatalayout.User;
                this.displayOrderLayout.Order = this.order;
                this.Controls.Remove(this.userDatalayout);
                this.Controls.Add(this.displayOrderLayout);
                this.displayOrderLayout.SendToBack();
                this.continueButton.Click -= this.SwitchLayout;
                this.continueButton.Click += new EventHandler(this.ConfirmOrder);
                this.continueButton.Text = "Continue and Pay";
            } 
            else
            {
                string message = "Please fill at least your name, address and phone number.";
                string caption = "Kitbox warning";
                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, caption, button);
            }
        }

        private void ConfirmOrder(object sender, EventArgs e)
        {
            string message = "Please follow the instruction on the terminal.";
            string caption = "Kitbox payement";
            MessageBoxButtons button = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, caption, button);
            if (result == DialogResult.OK) {
                this.order.SaveOrder();
                Database.CheckStock();
                this.resetApp();
            }
        }

        private void MountLayout()
        {
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.backButton);
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

            //
            // BackButton
            //
            this.backButton.Location = new System.Drawing.Point(10, 10);
            this.backButton.Size = new System.Drawing.Size(120, 64);
            this.backButton.Text = "Back";
            this.backButton.Click += new EventHandler(this.backAction);
        }
    }
}
