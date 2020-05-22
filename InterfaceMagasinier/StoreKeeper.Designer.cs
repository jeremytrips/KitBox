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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StockPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OrderPage = new System.Windows.Forms.TabPage();
            this.MagasinGroupBcx = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnRefreshOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewOrderProgress = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.kitboxDataSet = new InterfaceMagasinier.kitboxDataSet();
            this.clientorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_orderTableAdapter = new InterfaceMagasinier.kitboxDataSetTableAdapters.client_orderTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.kitboxDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.componentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.componentTableAdapter = new InterfaceMagasinier.kitboxDataSetTableAdapters.componentTableAdapter();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientorderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientorderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alreadypaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.StockPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.OrderPage.SuspendLayout();
            this.MagasinGroupBcx.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitboxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitboxDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientorderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientorderBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.OrderPage);
            this.tabControl1.Controls.Add(this.StockPage);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(71, 30);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1302, 1221);
            this.tabControl1.TabIndex = 0;
            // 
            // StockPage
            // 
            this.StockPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StockPage.Controls.Add(this.groupBox5);
            this.StockPage.Controls.Add(this.groupBox6);
            this.StockPage.Controls.Add(this.groupBox3);
            this.StockPage.Controls.Add(this.groupBox2);
            this.StockPage.Location = new System.Drawing.Point(4, 34);
            this.StockPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StockPage.Name = "StockPage";
            this.StockPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StockPage.Size = new System.Drawing.Size(1294, 1183);
            this.StockPage.TabIndex = 0;
            this.StockPage.Text = "Manage Stock";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox3.Location = new System.Drawing.Point(7, 523);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1281, 310);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Out of stock";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox5.Location = new System.Drawing.Point(19, 840);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(585, 317);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Update Stock";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(21, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(353, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "New stock:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(359, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 41);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 41);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox2.Location = new System.Drawing.Point(7, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1281, 507);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // OrderPage
            // 
            this.OrderPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OrderPage.Controls.Add(this.MagasinGroupBcx);
            this.OrderPage.Location = new System.Drawing.Point(4, 34);
            this.OrderPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderPage.Name = "OrderPage";
            this.OrderPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderPage.Size = new System.Drawing.Size(1294, 1183);
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
            this.MagasinGroupBcx.Location = new System.Drawing.Point(3, 8);
            this.MagasinGroupBcx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MagasinGroupBcx.Name = "MagasinGroupBcx";
            this.MagasinGroupBcx.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MagasinGroupBcx.Size = new System.Drawing.Size(1105, 786);
            this.MagasinGroupBcx.TabIndex = 3;
            this.MagasinGroupBcx.TabStop = false;
            this.MagasinGroupBcx.Enter += new System.EventHandler(this.MagasinGroupBcx_Enter);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewOrderProgress);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox4.Location = new System.Drawing.Point(-3, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(1288, 725);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order in progress";
            // 
            // dataGridViewOrderProgress
            // 
            this.dataGridViewOrderProgress.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderProgress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrderProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderProgress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idorderDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1,
            this.alreadypaidDataGridViewTextBoxColumn,
            this.ordernameDataGridViewTextBoxColumn});
            this.dataGridViewOrderProgress.DataSource = this.clientorderBindingSource2;
            this.dataGridViewOrderProgress.Location = new System.Drawing.Point(11, 44);
            this.dataGridViewOrderProgress.Name = "dataGridViewOrderProgress";
            this.dataGridViewOrderProgress.RowHeadersWidth = 62;
            this.dataGridViewOrderProgress.RowTemplate.Height = 28;
            this.dataGridViewOrderProgress.Size = new System.Drawing.Size(1097, 674);
            this.dataGridViewOrderProgress.TabIndex = 0;
            this.dataGridViewOrderProgress.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridViewOrderProgress.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.depthDataGridViewTextBoxColumn,
            this.referenceDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.componentBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 47);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(1269, 440);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // kitboxDataSetBindingSource
            // 
            this.kitboxDataSetBindingSource.DataSource = this.kitboxDataSet;
            this.kitboxDataSetBindingSource.Position = 0;
            // 
            // componentBindingSource
            // 
            this.componentBindingSource.DataMember = "component";
            this.componentBindingSource.DataSource = this.kitboxDataSetBindingSource;
            // 
            // componentTableAdapter
            // 
            this.componentTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.textBox5);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox6.Location = new System.Drawing.Point(610, 840);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(678, 336);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Update Price";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(17, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(358, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "New stock:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(18, 96);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 41);
            this.textBox5.TabIndex = 4;
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
            this.textBox3.Location = new System.Drawing.Point(364, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 41);
            this.textBox3.TabIndex = 5;
            // 
            // dataGridView4
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(12, 63);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(1269, 236);
            this.dataGridView4.TabIndex = 0;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Width = 150;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "height";
            this.heightDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.Width = 150;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "width";
            this.widthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.Width = 150;
            // 
            // depthDataGridViewTextBoxColumn
            // 
            this.depthDataGridViewTextBoxColumn.DataPropertyName = "depth";
            this.depthDataGridViewTextBoxColumn.HeaderText = "depth";
            this.depthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
            this.depthDataGridViewTextBoxColumn.Width = 150;
            // 
            // referenceDataGridViewTextBoxColumn
            // 
            this.referenceDataGridViewTextBoxColumn.DataPropertyName = "reference";
            this.referenceDataGridViewTextBoxColumn.HeaderText = "reference";
            this.referenceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.referenceDataGridViewTextBoxColumn.Name = "referenceDataGridViewTextBoxColumn";
            this.referenceDataGridViewTextBoxColumn.Width = 150;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientorderBindingSource1
            // 
            this.clientorderBindingSource1.DataMember = "client_order";
            this.clientorderBindingSource1.DataSource = this.kitboxDataSetBindingSource;
            this.clientorderBindingSource1.CurrentChanged += new System.EventHandler(this.clientorderBindingSource1_CurrentChanged);
            // 
            // clientorderBindingSource2
            // 
            this.clientorderBindingSource2.DataMember = "client_order";
            this.clientorderBindingSource2.DataSource = this.kitboxDataSet;
            // 
            // idorderDataGridViewTextBoxColumn
            // 
            this.idorderDataGridViewTextBoxColumn.DataPropertyName = "id_order";
            this.idorderDataGridViewTextBoxColumn.HeaderText = "id_order";
            this.idorderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idorderDataGridViewTextBoxColumn.Name = "idorderDataGridViewTextBoxColumn";
            this.idorderDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.Width = 150;
            // 
            // alreadypaidDataGridViewTextBoxColumn
            // 
            this.alreadypaidDataGridViewTextBoxColumn.DataPropertyName = "already_paid";
            this.alreadypaidDataGridViewTextBoxColumn.HeaderText = "already_paid";
            this.alreadypaidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alreadypaidDataGridViewTextBoxColumn.Name = "alreadypaidDataGridViewTextBoxColumn";
            this.alreadypaidDataGridViewTextBoxColumn.Width = 200;
            // 
            // ordernameDataGridViewTextBoxColumn
            // 
            this.ordernameDataGridViewTextBoxColumn.DataPropertyName = "order_name";
            this.ordernameDataGridViewTextBoxColumn.HeaderText = "order_name";
            this.ordernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ordernameDataGridViewTextBoxColumn.Name = "ordernameDataGridViewTextBoxColumn";
            this.ordernameDataGridViewTextBoxColumn.Width = 200;
            // 
            // StoreKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1317, 1247);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StoreKeeper";
            this.Text = "StoreKeeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.StockPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.OrderPage.ResumeLayout(false);
            this.MagasinGroupBcx.ResumeLayout(false);
            this.MagasinGroupBcx.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitboxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitboxDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientorderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientorderBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StockPage;
        private System.Windows.Forms.TabPage OrderPage;
        private System.Windows.Forms.GroupBox MagasinGroupBcx;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRefreshOrder;
        private kitboxDataSet kitboxDataSet;
        private System.Windows.Forms.BindingSource clientorderBindingSource;
        private kitboxDataSetTableAdapters.client_orderTableAdapter client_orderTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewOrderProgress;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource kitboxDataSetBindingSource;
        private System.Windows.Forms.BindingSource componentBindingSource;
        private kitboxDataSetTableAdapters.componentTableAdapter componentTableAdapter;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource clientorderBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientorderBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alreadypaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernameDataGridViewTextBoxColumn;
    }
}

