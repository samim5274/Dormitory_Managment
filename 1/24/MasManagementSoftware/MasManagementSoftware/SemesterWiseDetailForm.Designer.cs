namespace MasManagementSoftware
{
    partial class SemesterWiseDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSemester = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.cbxSemester = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemester)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSemester
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff;
            this.dgvSemester.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSemester.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSemester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemester.Location = new System.Drawing.Point(44, 226);
            this.dgvSemester.Name = "dgvSemester";
            this.dgvSemester.RowTemplate.Height = 24;
            this.dgvSemester.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSemester.Size = new System.Drawing.Size(1195, 482);
            this.dgvSemester.TabIndex = 9;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(295, 151);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(740, 51);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cbxSemester
            // 
            this.cbxSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSemester.FormattingEnabled = true;
            this.cbxSemester.Location = new System.Drawing.Point(539, 98);
            this.cbxSemester.Name = "cbxSemester";
            this.cbxSemester.Size = new System.Drawing.Size(341, 37);
            this.cbxSemester.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Semester Wise Detail";
            // 
            // SemesterWiseDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1282, 732);
            this.Controls.Add(this.dgvSemester);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cbxSemester);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SemesterWiseDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SemesterWiseDetailForm";
            this.Load += new System.EventHandler(this.SemesterWiseDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemester)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSemester;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cbxSemester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}