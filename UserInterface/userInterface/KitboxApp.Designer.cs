namespace userInterface
{
    partial class KitboxApp
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
            this.RemoveLayerButton = new System.Windows.Forms.Button();
            this.AddLayerButton = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kitBoxToOrderTabs
            // 
            this.kitBoxToOrderTabs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.kitBoxToOrderTabs.Location = new System.Drawing.Point(450, 90);
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
            // 
            // RemoveLayerButton
            // 
            this.RemoveLayerButton.Location = new System.Drawing.Point(456, 575);
            this.RemoveLayerButton.Name = "RemoveLayerButton";
            this.RemoveLayerButton.Size = new System.Drawing.Size(146, 23);
            this.RemoveLayerButton.TabIndex = 5;
            this.RemoveLayerButton.Text = "Remove layer on the kitbox";
            this.RemoveLayerButton.UseVisualStyleBackColor = true;
            this.RemoveLayerButton.Click += new System.EventHandler(this.RemoveLayerButton_Click);
            // 
            // AddLayerButton
            // 
            this.AddLayerButton.Location = new System.Drawing.Point(840, 575);
            this.AddLayerButton.Name = "AddLayerButton";
            this.AddLayerButton.Size = new System.Drawing.Size(146, 23);
            this.AddLayerButton.TabIndex = 6;
            this.AddLayerButton.Text = "Add a layer on the kitbox";
            this.AddLayerButton.UseVisualStyleBackColor = true;
            this.AddLayerButton.Click += new System.EventHandler(this.AddLayerButton_Click);
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(732, 631);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(147, 38);
            this.order.TabIndex = 7;
            this.order.Text = "Order kitbox";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(932, 3);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 8;
            this.reset.Text = "temp";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.order);
            this.Controls.Add(this.AddLayerButton);
            this.Controls.Add(this.RemoveLayerButton);
            this.Controls.Add(this.addKitBoxButton);
            this.Controls.Add(this.kitBoxToOrderTabs);
            this.Name = "Form1";
            this.Text = "s";
            this.ResumeLayout(false);

        }

        #endregion

        private OldOrderLayout oldOrderLayout;
        private System.Windows.Forms.TabControl kitBoxToOrderTabs;
        private System.Windows.Forms.Button addKitBoxButton;
        private System.Windows.Forms.Button RemoveLayerButton;
        private System.Windows.Forms.Button AddLayerButton;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button reset;
    }
}

