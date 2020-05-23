namespace InterfaceMagasinier
{
    partial class Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientordercomponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitboxDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitboxDataSet = new InterfaceMagasinier.kitboxDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.client_order_componentTableAdapter = new InterfaceMagasinier.kitboxDataSetTableAdapters.client_order_componentTableAdapter();
            this.btnPrint = new System.Windows.Forms.Button();
            this.componentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.componentTableAdapter = new InterfaceMagasinier.kitboxDataSetTableAdapters.componentTableAdapter();
            this.clientorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_orderTableAdapter = new InterfaceMagasinier.kitboxDataSetTableAdapters.client_orderTableAdapter();
            this.LabelIdName = new System.Windows.Forms.Label();
            this.labelOrderName = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientordercomponentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitboxDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitboxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientorderBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "N° of order :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "List of components :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Quantity});
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(13, 148);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(437, 441);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clientordercomponentBindingSource
            // 
            this.clientordercomponentBindingSource.DataMember = "client_order_component";
            this.clientordercomponentBindingSource.DataSource = this.kitboxDataSetBindingSource;
            // 
            // kitboxDataSetBindingSource
            // 
            this.kitboxDataSetBindingSource.DataSource = this.kitboxDataSet;
            this.kitboxDataSetBindingSource.Position = 0;
            // 
            // kitboxDataSet
            // 
            this.kitboxDataSet.DataSetName = "kitboxDataSet";
            this.kitboxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(346, 642);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(8, 642);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // client_order_componentTableAdapter
            // 
            this.client_order_componentTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPrint.Location = new System.Drawing.Point(346, 600);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 31);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // clientorderBindingSource
            // 
            this.clientorderBindingSource.DataMember = "client_order";
            this.clientorderBindingSource.DataSource = this.kitboxDataSet;
            // 
            // client_orderTableAdapter
            // 
            this.client_orderTableAdapter.ClearBeforeFill = true;
            // 
            // LabelIdName
            // 
            this.LabelIdName.AutoSize = true;
            this.LabelIdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelIdName.Location = new System.Drawing.Point(179, 57);
            this.LabelIdName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelIdName.Name = "LabelIdName";
            this.LabelIdName.Size = new System.Drawing.Size(65, 20);
            this.LabelIdName.TabIndex = 9;
            this.LabelIdName.Text = "IdName";
            // 
            // labelOrderName
            // 
            this.labelOrderName.AutoSize = true;
            this.labelOrderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelOrderName.Location = new System.Drawing.Point(179, 22);
            this.labelOrderName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderName.Name = "labelOrderName";
            this.labelOrderName.Size = new System.Drawing.Size(91, 20);
            this.labelOrderName.TabIndex = 10;
            this.labelOrderName.Text = "OrderName";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LabelIdName);
            this.panel1.Controls.Add(this.labelOrderName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 591);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDate.Location = new System.Drawing.Point(179, 87);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(44, 20);
            this.labelDate.TabIndex = 12;
            this.labelDate.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 8;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 683);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details of Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientordercomponentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitboxDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitboxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientorderBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource kitboxDataSetBindingSource;
        private kitboxDataSet kitboxDataSet;
        private System.Windows.Forms.BindingSource clientordercomponentBindingSource;
        private kitboxDataSetTableAdapters.client_order_componentTableAdapter client_order_componentTableAdapter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.BindingSource componentBindingSource;
        private kitboxDataSetTableAdapters.componentTableAdapter componentTableAdapter;
        private System.Windows.Forms.BindingSource clientorderBindingSource;
        private kitboxDataSetTableAdapters.client_orderTableAdapter client_orderTableAdapter;
        private System.Windows.Forms.Label LabelIdName;
        private System.Windows.Forms.Label labelOrderName;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}