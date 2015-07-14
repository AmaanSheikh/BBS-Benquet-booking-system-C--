namespace BBS
{
    partial class frmBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooking));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsbView = new System.Windows.Forms.ToolStripButton();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPerHead = new System.Windows.Forms.TextBox();
            this.lbxCoustomerView = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGuest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.newCoustomerdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newCoustomer_dbDataSet = new BBS.newCoustomer_dbDataSet();
            this.newCoustomer_dbTableAdapter = new BBS.newCoustomer_dbDataSetTableAdapters.newCoustomer_dbTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.newCoustomer_dbDataSet1 = new BBS.newCoustomer_dbDataSet1();
            this.newCoustomerdbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.newCoustomer_dbTableAdapter1 = new BBS.newCoustomer_dbDataSet1TableAdapters.newCoustomer_dbTableAdapter();
            this.dgvFunctionsDetails = new System.Windows.Forms.DataGridView();
            this.colFunctions = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartions = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.txtRemaining = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newCoustomerdbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCoustomer_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCoustomer_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCoustomerdbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctionsDetails)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbSave,
            this.tsbDelete,
            this.tsbClose,
            this.tsbView});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1162, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(53, 22);
            this.tsbNew.Text = "New";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(54, 22);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(65, 22);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(56, 22);
            this.tsbClose.Text = "Close";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tsbView
            // 
            this.tsbView.Image = ((System.Drawing.Image)(resources.GetObject("tsbView.Image")));
            this.tsbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbView.Name = "tsbView";
            this.tsbView.Size = new System.Drawing.Size(55, 22);
            this.tsbView.Text = "View";
            this.tsbView.Click += new System.EventHandler(this.tsbView_Click);
            // 
            // txtPayment
            // 
            this.txtPayment.BackColor = System.Drawing.Color.Black;
            this.txtPayment.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.ForeColor = System.Drawing.Color.White;
            this.txtPayment.Location = new System.Drawing.Point(491, 294);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(234, 33);
            this.txtPayment.TabIndex = 8;
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged_1);
            this.txtPayment.Enter += new System.EventHandler(this.txtPayment_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(174, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Per Head";
            // 
            // txtPerHead
            // 
            this.txtPerHead.Location = new System.Drawing.Point(250, 285);
            this.txtPerHead.Name = "txtPerHead";
            this.txtPerHead.Size = new System.Drawing.Size(58, 20);
            this.txtPerHead.TabIndex = 6;
            // 
            // lbxCoustomerView
            // 
            this.lbxCoustomerView.FormattingEnabled = true;
            this.lbxCoustomerView.Location = new System.Drawing.Point(491, 48);
            this.lbxCoustomerView.Name = "lbxCoustomerView";
            this.lbxCoustomerView.Size = new System.Drawing.Size(234, 225);
            this.lbxCoustomerView.TabIndex = 44;
            this.lbxCoustomerView.SelectedIndexChanged += new System.EventHandler(this.lbxCoustomerView_SelectedIndexChanged_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 248);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Adress";
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.Location = new System.Drawing.Point(89, 168);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(200, 67);
            this.txtAdress.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(89, 90);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(58, 20);
            this.txtCode.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "NO.of Guest";
            // 
            // txtGuest
            // 
            this.txtGuest.Location = new System.Drawing.Point(89, 285);
            this.txtGuest.Name = "txtGuest";
            this.txtGuest.Size = new System.Drawing.Size(58, 20);
            this.txtGuest.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Booking Date";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(89, 142);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Phone";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(89, 116);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::BBS.Properties.Resources.Untitled2;
            this.btnSave.Location = new System.Drawing.Point(465, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(284, 64);
            this.btnSave.TabIndex = 14;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_2);
            // 
            // newCoustomerdbBindingSource
            // 
            this.newCoustomerdbBindingSource.DataMember = "newCoustomer_db";
            this.newCoustomerdbBindingSource.DataSource = this.newCoustomer_dbDataSet;
            // 
            // newCoustomer_dbDataSet
            // 
            this.newCoustomer_dbDataSet.DataSetName = "newCoustomer_dbDataSet";
            this.newCoustomer_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newCoustomer_dbTableAdapter
            // 
            this.newCoustomer_dbTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 25);
            this.label10.TabIndex = 53;
            this.label10.Text = "Function Details";
            // 
            // newCoustomer_dbDataSet1
            // 
            this.newCoustomer_dbDataSet1.DataSetName = "newCoustomer_dbDataSet1";
            this.newCoustomer_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newCoustomerdbBindingSource1
            // 
            this.newCoustomerdbBindingSource1.DataMember = "newCoustomer_db";
            this.newCoustomerdbBindingSource1.DataSource = this.newCoustomer_dbDataSet1;
            // 
            // newCoustomer_dbTableAdapter1
            // 
            this.newCoustomer_dbTableAdapter1.ClearBeforeFill = true;
            // 
            // dgvFunctionsDetails
            // 
            this.dgvFunctionsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunctionsDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFunctions,
            this.date,
            this.colPartions,
            this.code});
            this.dgvFunctionsDetails.Location = new System.Drawing.Point(22, 369);
            this.dgvFunctionsDetails.Name = "dgvFunctionsDetails";
            this.dgvFunctionsDetails.Size = new System.Drawing.Size(382, 108);
            this.dgvFunctionsDetails.TabIndex = 7;
            // 
            // colFunctions
            // 
            this.colFunctions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFunctions.HeaderText = "Functions";
            this.colFunctions.Items.AddRange(new object[] {
            "MEHNDI",
            "BARAT"});
            this.colFunctions.Name = "colFunctions";
            this.colFunctions.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFunctions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colFunctions.Width = 78;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.HeaderText = "Dates";
            this.date.Name = "date";
            this.date.Width = 60;
            // 
            // colPartions
            // 
            this.colPartions.HeaderText = "Partion";
            this.colPartions.Items.AddRange(new object[] {
            "01",
            "02"});
            this.colPartions.Name = "colPartions";
            this.colPartions.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPartions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // code
            // 
            this.code.FillWeight = 50F;
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 25);
            this.label9.TabIndex = 55;
            this.label9.Text = "Coustomer Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(397, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Total Payment";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(428, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Advance";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(419, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "Remaining";
            // 
            // txtAdvance
            // 
            this.txtAdvance.BackColor = System.Drawing.Color.White;
            this.txtAdvance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvance.ForeColor = System.Drawing.Color.Lime;
            this.txtAdvance.Location = new System.Drawing.Point(491, 386);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(234, 33);
            this.txtAdvance.TabIndex = 10;
            this.txtAdvance.Enter += new System.EventHandler(this.btnCalculatePayment_Click);
            // 
            // txtRemaining
            // 
            this.txtRemaining.BackColor = System.Drawing.Color.Black;
            this.txtRemaining.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemaining.ForeColor = System.Drawing.Color.Red;
            this.txtRemaining.Location = new System.Drawing.Point(491, 435);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.Size = new System.Drawing.Size(238, 33);
            this.txtRemaining.TabIndex = 11;
            this.txtRemaining.Enter += new System.EventHandler(this.btnCalculatePayment_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.White;
            this.txtDiscount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.ForeColor = System.Drawing.Color.Lime;
            this.txtDiscount.Location = new System.Drawing.Point(491, 333);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(234, 33);
            this.txtDiscount.TabIndex = 9;
            this.txtDiscount.Enter += new System.EventHandler(this.btnCalculatePayment_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(428, 347);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 62;
            this.label14.Text = "Discount";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(753, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(381, 259);
            this.tabControl1.TabIndex = 63;
            // 
            // tabPage1
            // 
            this.tabPage1.DataBindings.Add(new System.Windows.Forms.Binding("AccessibleDescription", this.newCoustomerdbBindingSource1, "name", true));
            this.tabPage1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newCoustomerdbBindingSource, "code", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tabPage1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.newCoustomerdbBindingSource, "code", true));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(373, 233);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(373, 233);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 533);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbxCoustomerView);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.dgvFunctionsDetails);
            this.Controls.Add(this.txtRemaining);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAdvance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPerHead);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGuest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBooking";
            this.Text = " Booking New Coustomer";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newCoustomerdbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCoustomer_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCoustomer_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCoustomerdbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctionsDetails)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void txtPayment_TextChanged_1(object sender, System.EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPerHead;
        private System.Windows.Forms.ListBox lbxCoustomerView;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGuest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private newCoustomer_dbDataSet newCoustomer_dbDataSet;
        private System.Windows.Forms.BindingSource newCoustomerdbBindingSource;
        private newCoustomer_dbDataSetTableAdapters.newCoustomer_dbTableAdapter newCoustomer_dbTableAdapter;
        private System.Windows.Forms.Label label10;
        private newCoustomer_dbDataSet1 newCoustomer_dbDataSet1;
        private System.Windows.Forms.BindingSource newCoustomerdbBindingSource1;
        private newCoustomer_dbDataSet1TableAdapters.newCoustomer_dbTableAdapter newCoustomer_dbTableAdapter1;
        private System.Windows.Forms.DataGridView dgvFunctionsDetails;
        private System.Windows.Forms.DataGridViewComboBoxColumn colFunctions;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewComboBoxColumn colPartions;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton tsbView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.TextBox txtRemaining;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;


        public System.Windows.Forms.DataGridViewCellEventHandler dataGridView1_CellContentClick { get; set; }
    }
}