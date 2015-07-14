namespace BBS
{
    partial class frmchkavlibility
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
            this.newCoustomer_dbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new BBS.DataSet1();
            this.newCoustomer_dbTableAdapter = new BBS.DataSet1TableAdapters.newCoustomer_dbTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newCoustomerdbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bbs_dbDataSet = new BBS.bbs_dbDataSet();
            this.newCoustomerdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newCoustomer_dbTableAdapter1 = new BBS.bbs_dbDataSetTableAdapters.newCoustomer_dbTableAdapter();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newCoustomer_dbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCoustomerdbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbs_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCoustomerdbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // newCoustomer_dbBindingSource
            // 
            this.newCoustomer_dbBindingSource.DataMember = "newCoustomer_db";
            this.newCoustomer_dbBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet2";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newCoustomer_dbTableAdapter
            // 
            this.newCoustomer_dbTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 29);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // newCoustomerdbBindingSource1
            // 
            this.newCoustomerdbBindingSource1.DataMember = "newCoustomer_db";
            this.newCoustomerdbBindingSource1.DataSource = this.bbs_dbDataSet;
            // 
            // bbs_dbDataSet
            // 
            this.bbs_dbDataSet.DataSetName = "bbs_dbDataSet";
            this.bbs_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newCoustomerdbBindingSource
            // 
            this.newCoustomerdbBindingSource.DataMember = "newCoustomer_db";
            this.newCoustomerdbBindingSource.DataSource = this.bbs_dbDataSet;
            // 
            // newCoustomer_dbTableAdapter1
            // 
            this.newCoustomer_dbTableAdapter1.ClearBeforeFill = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(149, 80);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(73, 29);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Refresh";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "mm/dd/yyyy";
            // 
            // frmchkavlibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmchkavlibility";
            this.Text = "Check Availablity";
            this.Load += new System.EventHandler(this.frmchkavlibility_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newCoustomer_dbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCoustomerdbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbs_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCoustomerdbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource newCoustomer_dbBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.newCoustomer_dbTableAdapter newCoustomer_dbTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bbs_dbDataSet bbs_dbDataSet;
        private System.Windows.Forms.BindingSource newCoustomerdbBindingSource;
        private bbs_dbDataSetTableAdapters.newCoustomer_dbTableAdapter newCoustomer_dbTableAdapter1;
        private System.Windows.Forms.BindingSource newCoustomerdbBindingSource1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
    }
}