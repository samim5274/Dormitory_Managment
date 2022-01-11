using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasManagementSoftware
{
    public partial class MotherForm : Form
    {
        public MotherForm()
        {
            InitializeComponent();
        }

        private void departmentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new AddDepartmentForm();
            obj.Show();
        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new AddStudentInformatio();
            obj.Show();
        }

        private void purposeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new PurposeForm();
            obj.Show();
        }

        private void depositedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DipositFormcs();
            obj.Show();
        }

        private void monetGiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new MoneyWithdrawForm();
            obj.Show();
        }

        private void moneyTakeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void totalAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new GiveAndRicevedForm();
            obj.Show();
        }

        private void totalAmountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var obj = new TotalAmountLastForm();
            obj.Show();
        }
        
        private void giverWiseSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DayAndGiverWiseSummary();
            obj.Show();
        }

        private void riceverAndDayWiseSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DayAndRiceverWiseSummary();
            obj.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = DateTime.Now.ToString("T");
        }

        private void MotherForm_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer1.Start();
        }

        private void Timer_Elapsed(object sender,System.Timers.ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
                                         {
                                             lblStatus.Text = DateTime.Now.ToString("T");
                                         }));
        }

        private void countMilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new CountMilForm();
            obj.Show();
        }

        private void nameWiseMilSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new dgvMilDisplay();
            obj.Show();
        }

        private void dayWiseMilSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DayWiseMilSummary();
            obj.Show();
        }

        private void nameAndDayWiseMilSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new NameAndDayWiseMilSummaryForm();
            obj.Show();
        }

        private void expansesPaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new ExpansesPaidForm();
            obj.Show();
        }

        private void dayWiseExpansesDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DayWiseExpansesForm();
            obj.Show();
        }

        private void dayAndNameWiseExpansesDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DayAndNameWiseExpansesForm();
            obj.Show();
        }

        private void purposeWiseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new PurposeWiseForm();
            obj.Show();
        }

        private void dayWiseMilRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new MilRateForm();
            obj.Show();
        }

        private void semesterShiftGenderDepartmentWiseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new SemesterShiftGenderAndDepartmentWiseDetailForm();
            obj.Show();
        }

        private void departmentWiseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DepartmentWiseDetailForm();
            obj.Show();
        }

        private void semesterWiseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new SemesterWiseDetailForm();
            obj.Show();
        }

        private void shiftWiseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new ShiftWiseDetailForm();
            obj.Show();
        }

        private void genderWiseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new GenderWiseDetailForm();
            obj.Show();
        }

        private void genderAndDepartmentWiseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DepartmentAndGenderWiseDetailForm();
            obj.Show();
        }

        private void semesterAndGenderWiseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new SemesterAndGenderform();
            obj.Show();
        }

        private void departmentAndSemesterWiseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new SemesterAndDepartmentForm();
            obj.Show();
        }

        private void departmentAndShiftWiseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new ShiftAndDepartmentForm();
            obj.Show();
        }

        private void genderAndShiftWiseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new GenderAndShiftForm();
            obj.Show();
        }

        private void semesterAndShiftWiseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new SemesterAndShiftForm();
            obj.Show();
        }

        private void totalAmountToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var obj = new TotalAmountForm();
            obj.Show();
        }

        private void dayWiseTotalAmountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var obj = new DayByDayTotalAmountcs();
            obj.Show();
        }

    }
}
