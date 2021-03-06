﻿namespace userInterface
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
            this.removeKitBoxButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.addKitBoxButton.Location = new System.Drawing.Point(652, 584);
            this.addKitBoxButton.Name = "addKitBoxButton";
            this.addKitBoxButton.Size = new System.Drawing.Size(112, 31);
            this.addKitBoxButton.TabIndex = 0;
            this.addKitBoxButton.Text = "Add a KitBox";
            this.addKitBoxButton.UseVisualStyleBackColor = true;
            this.addKitBoxButton.Click += new System.EventHandler(this.AddKitbox_Click);
            // 
            // RemoveLayerButton
            // 
            this.RemoveLayerButton.Location = new System.Drawing.Point(456, 631);
            this.RemoveLayerButton.Name = "RemoveLayerButton";
            this.RemoveLayerButton.Size = new System.Drawing.Size(146, 31);
            this.RemoveLayerButton.TabIndex = 5;
            this.RemoveLayerButton.Text = "Remove layer";
            this.RemoveLayerButton.UseVisualStyleBackColor = true;
            this.RemoveLayerButton.Click += new System.EventHandler(this.RemoveLayerButton_Click);
            // 
            // AddLayerButton
            // 
            this.AddLayerButton.Location = new System.Drawing.Point(456, 584);
            this.AddLayerButton.Name = "AddLayerButton";
            this.AddLayerButton.Size = new System.Drawing.Size(146, 31);
            this.AddLayerButton.TabIndex = 6;
            this.AddLayerButton.Text = "Add a new layer";
            this.AddLayerButton.UseVisualStyleBackColor = true;
            this.AddLayerButton.Click += new System.EventHandler(this.AddLayerButton_Click);
            // 
            // order
            // 
            this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.Location = new System.Drawing.Point(816, 584);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(170, 78);
            this.order.TabIndex = 7;
            this.order.Text = "Confirm";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // removeKitBoxButton
            // 
            this.removeKitBoxButton.Location = new System.Drawing.Point(652, 631);
            this.removeKitBoxButton.Name = "removeKitBoxButton";
            this.removeKitBoxButton.Size = new System.Drawing.Size(113, 31);
            this.removeKitBoxButton.TabIndex = 9;
            this.removeKitBoxButton.Text = "Remove a KitBox";
            this.removeKitBoxButton.UseVisualStyleBackColor = true;
            this.removeKitBoxButton.Click += new System.EventHandler(this.removeKitBoxButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Click on a particular layer to modify it.";
            // 
            // KitboxApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeKitBoxButton);
            this.Controls.Add(this.order);
            this.Controls.Add(this.AddLayerButton);
            this.Controls.Add(this.RemoveLayerButton);
            this.Controls.Add(this.addKitBoxButton);
            this.Controls.Add(this.kitBoxToOrderTabs);
            this.Name = "KitboxApp";
            this.Text = "s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OldOrderLayout oldOrderLayout;
        private System.Windows.Forms.TabControl kitBoxToOrderTabs;
        private System.Windows.Forms.Button addKitBoxButton;
        private System.Windows.Forms.Button RemoveLayerButton;
        private System.Windows.Forms.Button AddLayerButton;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button removeKitBoxButton;
        private System.Windows.Forms.Label label1;
    }
}

