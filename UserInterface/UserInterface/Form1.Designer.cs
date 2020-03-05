namespace userInterface
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.kitBoxToOrderTabs = new System.Windows.Forms.TabControl();
            this.addKitBoxButton = new System.Windows.Forms.Button();
            this.newOrderDataLayout = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.newOrderDataLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // kitBoxToOrderTabs
            // 
            this.kitBoxToOrderTabs.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.kitBoxToOrderTabs.Location = new System.Drawing.Point(402, 60);
            this.kitBoxToOrderTabs.Name = "kitBoxToOrderTabs";
            this.kitBoxToOrderTabs.SelectedIndex = 0;
            this.kitBoxToOrderTabs.Size = new System.Drawing.Size(577, 552);
            this.kitBoxToOrderTabs.TabIndex = 4;
            // 
            // addKitBoxButton
            // 
            this.addKitBoxButton.Location = new System.Drawing.Point(872, 618);
            this.addKitBoxButton.Name = "addKitBoxButton";
            this.addKitBoxButton.Size = new System.Drawing.Size(107, 51);
            this.addKitBoxButton.TabIndex = 5;
            this.addKitBoxButton.Text = "Add a KitBox";
            this.addKitBoxButton.UseVisualStyleBackColor = true;
            this.addKitBoxButton.Click += new System.EventHandler(this.AddKitbox_Click);
            // 
            // newOrderDataLayout
            // 
            this.newOrderDataLayout.BackColor = System.Drawing.Color.RoyalBlue;
            this.newOrderDataLayout.Controls.Add(this.label1);
            this.newOrderDataLayout.Location = new System.Drawing.Point(34, 129);
            this.newOrderDataLayout.Name = "newOrderDataLayout";
            this.newOrderDataLayout.Size = new System.Drawing.Size(330, 483);
            this.newOrderDataLayout.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.newOrderDataLayout);
            this.Controls.Add(this.addKitBoxButton);
            this.Controls.Add(this.kitBoxToOrderTabs);
            this.Name = "Form1";
            this.Text = "My fck kitbox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.newOrderDataLayout.ResumeLayout(false);
            this.newOrderDataLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OldOrderLayout oldOrderLayout;
        private System.Windows.Forms.TabControl kitBoxToOrderTabs;
        private System.Windows.Forms.Button addKitBoxButton;
        private System.Windows.Forms.Panel newOrderDataLayout;
        private System.Windows.Forms.Label label1;
    }
}

