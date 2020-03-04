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

            this.oldOrderLayout = new OldOrderLayout(this.HandleOldOrder); 
            this.kitBoxToOrderTabs = new System.Windows.Forms.TabControl();
            this.addKitBoxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // kitBoxToOrderTabs
            // 
            this.kitBoxToOrderTabs.Location = new System.Drawing.Point(363, 182);
            this.kitBoxToOrderTabs.Name = "kitBoxToOrderTabs";
            this.kitBoxToOrderTabs.SelectedIndex = 0;
            this.kitBoxToOrderTabs.Size = new System.Drawing.Size(577, 385);
            this.kitBoxToOrderTabs.TabIndex = 4;

            // 
            // AddKitBoxButton
            // 
            this.addKitBoxButton.Location = new System.Drawing.Point(833, 605);
            this.addKitBoxButton.Name = "AddKitBoxButton";
            this.addKitBoxButton.Size = new System.Drawing.Size(107, 51);
            this.addKitBoxButton.TabIndex = 5;
            this.addKitBoxButton.Text = "Add a KitBox";
            this.addKitBoxButton.UseVisualStyleBackColor = true;
            this.addKitBoxButton.Click += new System.EventHandler(this.AddKitbox_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.addKitBoxButton);
            this.Controls.Add(this.kitBoxToOrderTabs);
            this.Controls.Add(this.oldOrderLayout);
            this.Name = "Form1";
            this.Text = "My fck kitbox";
            this.ResumeLayout(false);

        }

        #endregion

        private OldOrderLayout oldOrderLayout;
        private System.Windows.Forms.TabControl kitBoxToOrderTabs;
        private System.Windows.Forms.Button addKitBoxButton;
    }
}

