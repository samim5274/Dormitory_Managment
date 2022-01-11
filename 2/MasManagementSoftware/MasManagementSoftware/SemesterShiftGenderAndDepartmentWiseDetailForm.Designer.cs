namespace MasManagementSoftware
{
    partial class SemesterShiftGenderAndDepartmentWiseDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.cbxSemester = new System.Windows.Forms.ComboBox();
            this.cbxShift = new System.Windows.Forms.ComboBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvDSSG = new System.Windows.Forms.DataGridView();
            this.dORMITORYDataSet2 = new MasManagementSoftware.DORMITORYDataSet2();
            this.sPSEMESTERSHIFTGENDERandDEPARTMENTWISESUMMARYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_SEMESTER_SHIFT_GENDER_and_DEPARTMENTWISESUMMARYTableAdapter = new MasManagementSoftware.DORMITORYDataSet2TableAdapters.SP_SEMESTER_SHIFT_GENDER_and_DEPARTMENTWISESUMMARYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dORMITORYDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSEMESTERSHIFTGENDERandDEPARTMENTWISESUMMARYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1001, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semester, Shift, Gender and Department wise Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(702, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shift";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(689, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Department";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(262, 82);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(343, 37);
            this.cbxDepartment.TabIndex = 5;
            // 
            // cbxSemester
            // 
            this.cbxSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSemester.FormattingEnabled = true;
            this.cbxSemester.Location = new System.Drawing.Point(262, 149);
            this.cbxSemester.Name = "cbxSemester";
            this.cbxSemester.Size = new System.Drawing.Size(343, 37);
            this.cbxSemester.TabIndex = 6;
            // 
            // cbxShift
            // 
            this.cbxShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxShift.FormattingEnabled = true;
            this.cbxShift.Location = new System.Drawing.Point(782, 82);
            this.cbxShift.Name = "cbxShift";
            this.cbxShift.Size = new System.Drawing.Size(343, 37);
            this.cbxShift.TabIndex = 7;
            // 
            // cbxGender
            // 
            this.cbxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(782, 149);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(343, 37);
            this.cbxGender.TabIndex = 8;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(393, 204);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(547, 48);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvDSSG
            // 
            this.dgvDSSG.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            this.dgvDSSG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSSG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSG.Location = new System.Drawing.Point(30, 268);
            this.dgvDSSG.Name = "dgvDSSG";
            this.dgvDSSG.RowTemplate.Height = 24;
            this.dgvDSSG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSG.Size = new System.Drawing.Size(1201, 439);
            this.dgvDSSG.TabIndex = 10;
            // 
            // dORMITORYDataSet2
            // 
            this.dORMITORYDataSet2.DataSetName = "DORMITORYDataSet2";
            this.dORMITORYDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPSEMESTERSHIFTGENDERandDEPARTMENTWISESUMMARYBindingSource
            // 
            this.sPSEMESTERSHIFTGENDERandDEPARTMENTWISESUMMARYBindingSource.DataMember = "SP_SEMESTER_SHIFT_GENDER_and_DEPARTMENTWISESUMMARY";
            this.sPSEMESTERSHIFTGENDERandDEPARTMENTWISESUMMARYBindingSource.DataSource = this.dORMITORYDataSet2;
            // 
            // sP_SEMESTER_SHIFT_GENDER_and_DEPARTMENTWISESUMMARYTableAdapter
            // 
            this.sP_SEMESTER_SHIFT_GENDER_and_DEPARTMENTWISESUMMARYTableAdapter.ClearBeforeFill = true;
            // 
            // SemesterShiftGenderAndDepartmentWiseDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 731);
            this.Controls.Add(this.dgvDSSG);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.cbxShift);
            this.Controls.Add(this.cbxSemester);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SemesterShiftGenderAndDepartmentWiseDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SemesterShiftGenderAndDepartmentWiseDetailForm";
            this.Load += new System.EventHandler(this.SemesterShiftGenderAndDepartmentWiseDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dORMITORYDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSEMESTERSHIFTGENDERandDEPARTMENTWISESUMMARYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.ComboBox cbxSemester;
        private System.Windows.Forms.ComboBox cbxShift;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgvDSSG;
        private System.Windows.Forms.BindingSource sPSEMESTERSHIFTGENDERandDEPARTMENTWISESUMMARYBindingSource;
        private DORMITORYDataSet2 dORMITORYDataSet2;
        private DORMITORYDataSet2TableAdapters.SP_SEMESTER_SHIFT_GENDER_and_DEPARTMENTWISESUMMARYTableAdapter sP_SEMESTER_SHIFT_GENDER_and_DEPARTMENTWISESUMMARYTableAdapter;
    }
}