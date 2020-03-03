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
            this.oldOrderButton = new System.Windows.Forms.Button();
            this.oldOrderName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // oldOrderButton
            // 
            this.oldOrderButton.Location = new System.Drawing.Point(34, 52);
            this.oldOrderButton.Name = "oldOrderButton";
            this.oldOrderButton.Size = new System.Drawing.Size(152, 35);
            this.oldOrderButton.TabIndex = 0;
            this.oldOrderButton.Text = "Select an old order";
            this.oldOrderButton.UseVisualStyleBackColor = true;
            this.oldOrderButton.Click += new System.EventHandler(this.oldOrderButton_Click);
            // 
            // oldOrderName
            // 
            this.oldOrderName.Location = new System.Drawing.Point(34, 26);
            this.oldOrderName.Name = "oldOrderName";
            this.oldOrderName.Size = new System.Drawing.Size(152, 20);
            this.oldOrderName.TabIndex = 1;
            this.oldOrderName.Enter += new System.EventHandler(this.oldOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.oldOrderName);
            this.Controls.Add(this.oldOrderButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oldOrderButton;
        private System.Windows.Forms.TextBox oldOrderName;
    }
}

