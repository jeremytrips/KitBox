namespace InterfaceMagasinier
{
    partial class StoreKeeper
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StockPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listOfComponents = new System.Windows.Forms.ListBox();
            this.OrderPage = new System.Windows.Forms.TabPage();
            this.MagasinGroupBcx = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.listOutStock = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRefreshOrder = new System.Windows.Forms.Button();
            this.kitboxDataSet = new InterfaceMagasinier.kitboxDataSet();
            this.clientorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_orderTableAdapter = new InterfaceMagasinier.kitboxDataSetTableAdapters.client_orderTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.StockPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.OrderPage.SuspendLayout();
            this.MagasinGroupBcx.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitboxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.StockPage);
            this.tabControl1.Controls.Add(this.OrderPage);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(71, 30);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1125, 832);
            this.tabControl1.TabIndex = 0;
            // 
            // StockPage
            // 
            this.StockPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StockPage.Controls.Add(this.groupBox6);
            this.StockPage.Controls.Add(this.groupBox3);
            this.StockPage.Controls.Add(this.groupBox5);
            this.StockPage.Controls.Add(this.groupBox2);
            this.StockPage.Location = new System.Drawing.Point(4, 34);
            this.StockPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StockPage.Name = "StockPage";
            this.StockPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StockPage.Size = new System.Drawing.Size(1117, 794);
            this.StockPage.TabIndex = 0;
            this.StockPage.Text = "Manage Stock";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listOutStock);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox3.Location = new System.Drawing.Point(558, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(553, 426);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Out of stock";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listOfComponents);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox2.Location = new System.Drawing.Point(7, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(545, 852);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // listOfComponents
            // 
            this.listOfComponents.FormattingEnabled = true;
            this.listOfComponents.ItemHeight = 36;
            this.listOfComponents.Location = new System.Drawing.Point(6, 42);
            this.listOfComponents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listOfComponents.Name = "listOfComponents";
            this.listOfComponents.Size = new System.Drawing.Size(531, 724);
            this.listOfComponents.TabIndex = 11;
            this.listOfComponents.SelectedIndexChanged += new System.EventHandler(this.ListOfComponents_SelectedIndexChanged);
            // 
            // OrderPage
            // 
            this.OrderPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OrderPage.Controls.Add(this.MagasinGroupBcx);
            this.OrderPage.Location = new System.Drawing.Point(4, 34);
            this.OrderPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderPage.Name = "OrderPage";
            this.OrderPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderPage.Size = new System.Drawing.Size(1117, 794);
            this.OrderPage.TabIndex = 1;
            this.OrderPage.Text = "Manage Orders";
            // 
            // MagasinGroupBcx
            // 
            this.MagasinGroupBcx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MagasinGroupBcx.Controls.Add(this.button5);
            this.MagasinGroupBcx.Controls.Add(this.btnRefreshOrder);
            this.MagasinGroupBcx.Controls.Add(this.button1);
            this.MagasinGroupBcx.Controls.Add(this.groupBox4);
            this.MagasinGroupBcx.Controls.Add(this.textBox4);
            this.MagasinGroupBcx.Controls.Add(this.groupBox1);
            this.MagasinGroupBcx.Location = new System.Drawing.Point(3, 8);
            this.MagasinGroupBcx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MagasinGroupBcx.Name = "MagasinGroupBcx";
            this.MagasinGroupBcx.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MagasinGroupBcx.Size = new System.Drawing.Size(1105, 786);
            this.MagasinGroupBcx.TabIndex = 3;
            this.MagasinGroupBcx.TabStop = false;
            this.MagasinGroupBcx.Enter += new System.EventHandler(this.MagasinGroupBcx_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox4.Location = new System.Drawing.Point(-3, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(1117, 356);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order in progress";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.Location = new System.Drawing.Point(-3, 364);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1117, 353);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order completed";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Location = new System.Drawing.Point(8, 733);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.MinimumSize = new System.Drawing.Size(112, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(245, 41);
            this.textBox4.TabIndex = 21;
            this.textBox4.Text = "Search ...";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.Location = new System.Drawing.Point(298, 733);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 41);
            this.button5.TabIndex = 13;
            this.button5.Text = "Show More ...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click_1);
            // 
            // listOutStock
            // 
            this.listOutStock.FormattingEnabled = true;
            this.listOutStock.ItemHeight = 36;
            this.listOutStock.Location = new System.Drawing.Point(8, 45);
            this.listOutStock.Name = "listOutStock";
            this.listOutStock.Size = new System.Drawing.Size(509, 364);
            this.listOutStock.TabIndex = 0;
            this.listOutStock.UseWaitCursor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.textBox5);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox6.Location = new System.Drawing.Point(825, 441);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(250, 333);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Update Price";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox5.Location = new System.Drawing.Point(566, 441);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 333);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Update Stock";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 41);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 41);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reference Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(17, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "New stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "New stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Reference Number:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 205);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 41);
            this.textBox3.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(18, 96);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 41);
            this.textBox5.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button1.Image = global::InterfaceMagasinier.Properties.Resources.loupe;
            this.button1.Location = new System.Drawing.Point(216, 733);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 41);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(22, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(17, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnRefreshOrder
            // 
            this.btnRefreshOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshOrder.Location = new System.Drawing.Point(979, 733);
            this.btnRefreshOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshOrder.Name = "btnRefreshOrder";
            this.btnRefreshOrder.Size = new System.Drawing.Size(126, 41);
            this.btnRefreshOrder.TabIndex = 23;
            this.btnRefreshOrder.Text = "Refresh";
            this.btnRefreshOrder.UseVisualStyleBackColor = true;
            this.btnRefreshOrder.Click += new System.EventHandler(this.btnRefreshOrder_Click);
            // 
            // kitboxDataSet
            // 
            this.kitboxDataSet.DataSetName = "kitboxDataSet";
            this.kitboxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientorderBindingSource
            // 
            this.clientorderBindingSource.DataMember = "client_order";
            this.clientorderBindingSource.DataSource = this.kitboxDataSet;
            // 
            // client_orderTableAdapter
            // 
            this.client_orderTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1091, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(11, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1097, 306);
            this.dataGridView2.TabIndex = 0;
            // 
            // StoreKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1152, 861);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StoreKeeper";
            this.Text = "StoreKeeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.StockPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.OrderPage.ResumeLayout(false);
            this.MagasinGroupBcx.ResumeLayout(false);
            this.MagasinGroupBcx.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitboxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StockPage;
        private System.Windows.Forms.TabPage OrderPage;
        private System.Windows.Forms.GroupBox MagasinGroupBcx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listOfComponents;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listOutStock;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRefreshOrder;
        private kitboxDataSet kitboxDataSet;
        private System.Windows.Forms.BindingSource clientorderBindingSource;
        private kitboxDataSetTableAdapters.client_orderTableAdapter client_orderTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

