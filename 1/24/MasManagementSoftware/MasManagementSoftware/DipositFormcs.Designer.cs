namespace MasManagementSoftware
{
    partial class DipositFormcs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbxGiverName = new System.Windows.Forms.ComboBox();
            this.cbxReciverName = new System.Windows.Forms.ComboBox();
            this.cbxPurpose = new System.Windows.Forms.ComboBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtpDipositView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciverIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPGRIDVIEWDIPOSITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dORMITORYDataSet1 = new MasManagementSoftware.DORMITORYDataSet1();
            this.lblTotal = new System.Windows.Forms.Label();
            this.sP_GRIDVIEWDIPOSITTableAdapter = new MasManagementSoftware.DORMITORYDataSet1TableAdapters.SP_GRIDVIEWDIPOSITTableAdapter();
            this.dORMITORYDataSet = new MasManagementSoftware.DORMITORYDataSet();
            this.sPGRIDVIEWDISPLAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GRIDVIEWDISPLAYTableAdapter = new MasManagementSoftware.DORMITORYDataSetTableAdapters.SP_GRIDVIEWDISPLAYTableAdapter();
            this.sPGRIDVIEWDIPOSITBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnScarch = new System.Windows.Forms.Button();
            this.txtScarch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCreaditMoney = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDipositView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGRIDVIEWDIPOSITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dORMITORYDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dORMITORYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGRIDVIEWDISPLAYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGRIDVIEWDIPOSITBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diposit Money Detail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giver Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reciver Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Purpose ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Money";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Enabled = false;
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(232, 100);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(317, 28);
            this.dtpDate.TabIndex = 6;
            // 
            // cbxGiverName
            // 
            this.cbxGiverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGiverName.FormattingEnabled = true;
            this.cbxGiverName.Location = new System.Drawing.Point(200, 153);
            this.cbxGiverName.Name = "cbxGiverName";
            this.cbxGiverName.Size = new System.Drawing.Size(321, 37);
            this.cbxGiverName.TabIndex = 7;
            // 
            // cbxReciverName
            // 
            this.cbxReciverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxReciverName.FormattingEnabled = true;
            this.cbxReciverName.Location = new System.Drawing.Point(200, 206);
            this.cbxReciverName.Name = "cbxReciverName";
            this.cbxReciverName.Size = new System.Drawing.Size(321, 37);
            this.cbxReciverName.TabIndex = 8;
            // 
            // cbxPurpose
            // 
            this.cbxPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPurpose.FormattingEnabled = true;
            this.cbxPurpose.Location = new System.Drawing.Point(200, 260);
            this.cbxPurpose.Name = "cbxPurpose";
            this.cbxPurpose.Size = new System.Drawing.Size(321, 37);
            this.cbxPurpose.TabIndex = 9;
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(200, 313);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(321, 34);
            this.txtMoney.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(200, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(321, 50);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(555, 136);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(265, 59);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(555, 206);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(265, 59);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(555, 277);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(265, 59);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(555, 347);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(265, 59);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtpDipositView
            // 
            this.dtpDipositView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff;
            this.dtpDipositView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtpDipositView.AutoGenerateColumns = false;
            this.dtpDipositView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtpDipositView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.reciverIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn});
            this.dtpDipositView.DataSource = this.sPGRIDVIEWDIPOSITBindingSource;
            this.dtpDipositView.Location = new System.Drawing.Point(12, 434);
            this.dtpDipositView.Name = "dtpDipositView";
            this.dtpDipositView.RowTemplate.Height = 24;
            this.dtpDipositView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtpDipositView.Size = new System.Drawing.Size(1199, 220);
            this.dtpDipositView.TabIndex = 18;
            this.dtpDipositView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtpDipositView_CellContentClick);
            this.dtpDipositView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtpDipositView_CellEndEdit);
            this.dtpDipositView.DoubleClick += new System.EventHandler(this.dtpDipositView_DoubleClick);
            this.dtpDipositView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtpDipositView_MouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // reciverIdDataGridViewTextBoxColumn
            // 
            this.reciverIdDataGridViewTextBoxColumn.DataPropertyName = "ReciverId";
            this.reciverIdDataGridViewTextBoxColumn.HeaderText = "ReciverId";
            this.reciverIdDataGridViewTextBoxColumn.Name = "reciverIdDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "Money";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            // 
            // sPGRIDVIEWDIPOSITBindingSource
            // 
            this.sPGRIDVIEWDIPOSITBindingSource.DataMember = "SP_GRIDVIEWDIPOSIT";
            this.sPGRIDVIEWDIPOSITBindingSource.DataSource = this.dORMITORYDataSet1;
            // 
            // dORMITORYDataSet1
            // 
            this.dORMITORYDataSet1.DataSetName = "DORMITORYDataSet1";
            this.dORMITORYDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1080, 676);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(23, 25);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "0";
            // 
            // sP_GRIDVIEWDIPOSITTableAdapter
            // 
            this.sP_GRIDVIEWDIPOSITTableAdapter.ClearBeforeFill = true;
            // 
            // dORMITORYDataSet
            // 
            this.dORMITORYDataSet.DataSetName = "DORMITORYDataSet";
            this.dORMITORYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPGRIDVIEWDISPLAYBindingSource
            // 
            this.sPGRIDVIEWDISPLAYBindingSource.DataMember = "SP_GRIDVIEWDISPLAY";
            this.sPGRIDVIEWDISPLAYBindingSource.DataSource = this.dORMITORYDataSet;
            // 
            // sP_GRIDVIEWDISPLAYTableAdapter
            // 
            this.sP_GRIDVIEWDISPLAYTableAdapter.ClearBeforeFill = true;
            // 
            // sPGRIDVIEWDIPOSITBindingSource1
            // 
            this.sPGRIDVIEWDIPOSITBindingSource1.DataMember = "SP_GRIDVIEWDIPOSIT";
            this.sPGRIDVIEWDIPOSITBindingSource1.DataSource = this.dORMITORYDataSet1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Total Amount";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(909, 676);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Total Amount $ :";
            // 
            // btnScarch
            // 
            this.btnScarch.Location = new System.Drawing.Point(1090, 28);
            this.btnScarch.Name = "btnScarch";
            this.btnScarch.Size = new System.Drawing.Size(106, 38);
            this.btnScarch.TabIndex = 25;
            this.btnScarch.Text = "Scarch";
            this.btnScarch.UseVisualStyleBackColor = true;
            this.btnScarch.Click += new System.EventHandler(this.btnScarch_Click_1);
            // 
            // txtScarch
            // 
            this.txtScarch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScarch.Location = new System.Drawing.Point(842, 30);
            this.txtScarch.Name = "txtScarch";
            this.txtScarch.Size = new System.Drawing.Size(242, 34);
            this.txtScarch.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MasManagementSoftware.Properties.Resources.online_education_learning_work_home_man_hand_writing_notebook_using_laptop_computer_adult_male_student_study_course_177445400;
            this.pictureBox1.Location = new System.Drawing.Point(841, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txtCreaditMoney
            // 
            this.txtCreaditMoney.Location = new System.Drawing.Point(527, 347);
            this.txtCreaditMoney.Name = "txtCreaditMoney";
            this.txtCreaditMoney.Size = new System.Drawing.Size(19, 22);
            this.txtCreaditMoney.TabIndex = 68;
            this.txtCreaditMoney.Text = "0";
            this.txtCreaditMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCreaditMoney.Visible = false;
            // 
            // DipositFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1223, 722);
            this.Controls.Add(this.txtCreaditMoney);
            this.Controls.Add(this.btnScarch);
            this.Controls.Add(this.txtScarch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dtpDipositView);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.cbxPurpose);
            this.Controls.Add(this.cbxReciverName);
            this.Controls.Add(this.cbxGiverName);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DipositFormcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DipositFormcs";
            this.Load += new System.EventHandler(this.DipositFormcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtpDipositView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGRIDVIEWDIPOSITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dORMITORYDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dORMITORYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGRIDVIEWDISPLAYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGRIDVIEWDIPOSITBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbxGiverName;
        private System.Windows.Forms.ComboBox cbxReciverName;
        private System.Windows.Forms.ComboBox cbxPurpose;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dtpDipositView;
        private System.Windows.Forms.Label lblTotal;
        private DORMITORYDataSet1 dORMITORYDataSet1;
        private System.Windows.Forms.BindingSource sPGRIDVIEWDIPOSITBindingSource;
        private DORMITORYDataSet1TableAdapters.SP_GRIDVIEWDIPOSITTableAdapter sP_GRIDVIEWDIPOSITTableAdapter;
        private DORMITORYDataSet dORMITORYDataSet;
        private System.Windows.Forms.BindingSource sPGRIDVIEWDISPLAYBindingSource;
        private DORMITORYDataSetTableAdapters.SP_GRIDVIEWDISPLAYTableAdapter sP_GRIDVIEWDISPLAYTableAdapter;
        private System.Windows.Forms.BindingSource sPGRIDVIEWDIPOSITBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciverIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnScarch;
        private System.Windows.Forms.TextBox txtScarch;
        private System.Windows.Forms.TextBox txtCreaditMoney;
    }
}