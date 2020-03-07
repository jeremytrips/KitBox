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
            //this.generalDataPanel = new userInterface.GeneralDataPanel();
            //this.specificDataPanel = new userInterface.SpecificDataPanel();
            this.SuspendLayout();
            // 
            // kitBoxToOrderTabs
            // 
            this.kitBoxToOrderTabs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.kitBoxToOrderTabs.Location = new System.Drawing.Point(456, 89);
            this.kitBoxToOrderTabs.Name = "kitBoxToOrderTabs";
            this.kitBoxToOrderTabs.SelectedIndex = 0;
            this.kitBoxToOrderTabs.Size = new System.Drawing.Size(530, 480);
            this.kitBoxToOrderTabs.TabIndex = 4;
            this.kitBoxToOrderTabs.SelectedIndexChanged += new System.EventHandler(this.SetKitBoxData);
            // 
            // addKitBoxButton
            // 
            this.addKitBoxButton.Location = new System.Drawing.Point(156, 588);
            this.addKitBoxButton.Name = "addKitBoxButton";
            this.addKitBoxButton.Size = new System.Drawing.Size(150, 67);
            this.addKitBoxButton.TabIndex = 0;
            this.addKitBoxButton.Text = "Add a KitBox";
            this.addKitBoxButton.UseVisualStyleBackColor = true;
            this.addKitBoxButton.Click += new System.EventHandler(this.AddKitbox_Click);
            //// 
            //// generalDataPanel
            //// 
            //this.generalDataPanel.BackColor = System.Drawing.Color.Red;
            //this.generalDataPanel.Location = new System.Drawing.Point(30, 100);
            //this.generalDataPanel.Name = "generalDataPanel";
            //this.generalDataPanel.Size = new System.Drawing.Size(400, 113);
            //this.generalDataPanel.TabIndex = 5;
            //// 
            //// specificDataPanel
            //// 
            //this.specificDataPanel.BackColor = System.Drawing.Color.Red;
            //this.specificDataPanel.Location = new System.Drawing.Point(30, 219);
            //this.specificDataPanel.Name = "specificDataPanel";
            //this.specificDataPanel.Size = new System.Drawing.Size(400, 350);
            //this.specificDataPanel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.addKitBoxButton);
            this.Controls.Add(this.kitBoxToOrderTabs);
            this.Controls.Add(this.generalDataPanel);
            this.Controls.Add(this.specificDataPanel);
            this.Name = "Form1";
            this.Text = "My fck kitbox";
            this.ResumeLayout(false);

        }

        #endregion

        private SpecificDataPanel specificDataPanel;
        private GeneralDataPanel generalDataPanel;
        private OldOrderLayout oldOrderLayout;
        private System.Windows.Forms.TabControl kitBoxToOrderTabs;
        private System.Windows.Forms.Button addKitBoxButton;
    }
}

