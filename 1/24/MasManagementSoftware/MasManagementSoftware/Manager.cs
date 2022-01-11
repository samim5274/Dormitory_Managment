using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasManagementSoftware
{
    public class Manager
    {
        internal object GetAllGender()
        {
            var context = new DORMITORYEntities();
            var q = from Gen in context.GenderInfoes select Gen;
            return q.ToList();
        }

        internal object GetAllSemister()
        {
            var context = new DORMITORYEntities();
            var q = from Sem in context.SemisterInfoes select Sem;
            return q.ToList();
        }

        internal object GetAllShift()
        {
            var context = new DORMITORYEntities();
            var q = from sif in context.ShiftInfoes select sif;
            return q.ToList();
        }

        internal object GettAllDepartmetn()
        {
            var context = new DORMITORYEntities();
            var q = from dep in context.DepartmentInfoes select dep;
            return q.ToList();
        }

        internal object GellPurposeName()
        {
            var context = new DORMITORYEntities();
            var q = from pur in context.PurposeInfoes select pur;
            return q.ToList();
        }

        internal List<SP_GRIDVIEWDISPLAY_Result> GettGridView()
        {
            var contect = new DORMITORYEntities();
            var q = contect.SP_GRIDVIEWDISPLAY();
            return q.ToList();
        }

        internal object GetAllGiver()
        {
            var context = new DORMITORYEntities();
            var q = from SS in context.StudentInformations select SS;
            return q.ToList();
        }

        internal object GetAllPurpose()
        {
            var context = new DORMITORYEntities();
            var q = from PP in context.PurposeInfoes select PP;
            return q.ToList();
        }

        internal object GetAllReciver()
        {
            var context = new DORMITORYEntities();
            var q = from RR in context.StudentInformations select RR;
            return q.ToList();
        }

        internal List<SP_GRIDVIEWDIPOSIT_Result> GetDipositGrid()
        {
            var context = new DORMITORYEntities();
            var q = context.SP_GRIDVIEWDIPOSIT();
            return q.ToList();
        }

        internal List<SP_WITHDRAWGRIDVIEW_Result> GetWithdrawGridView()
        {
            var context = new DORMITORYEntities();
            var q = context.SP_WITHDRAWGRIDVIEW();
            return q.ToList();
        }

        internal List<SP_TOTALAMOUNTGRIDVIEW_Result> GettTotal()
        {
            var context = new DORMITORYEntities();
            var q = context.SP_TOTALAMOUNTGRIDVIEW();
            return q.ToList();
        }

        internal List<SP_REPORTGIVERANDRICEVERWISE_Result> GetGiverAndRicever(int GIVERID, int RICEVERID)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_REPORTGIVERANDRICEVERWISE(GIVERID, RICEVERID);
            return q.ToList();
        }

        internal List<SP_DAYBYDAYTOTALAMOUNT_Result> GetDayByDaySummary(DateTime STd, DateTime END)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_DAYBYDAYTOTALAMOUNT(STd,END);
            return q.ToList();
        }

        internal List<SP_GIVERANDDAYWISESUMMYDISPLAY_Result1> GetGiveAndDaySummary(DateTime STD, DateTime END, int GIV)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_GIVERANDDAYWISESUMMYDISPLAY(STD, END, GIV);
            return q.ToList();
        }

        internal List<SP_DAYANDRICEVERWISESUMMARY_Result> GetRiceverAndDaySummary(DateTime STD, DateTime END, int GIV)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_DAYANDRICEVERWISESUMMARY(STD, END, GIV);
            return q.ToList();
        }

        internal object GettAllStudentName()
        {
            var context = new DORMITORYEntities();
            var q = from SS in context.StudentInformations select SS;
            return q.ToList();
        }

        internal List<SP_MILDISPLAY_Result> GetMilGrid()
        {
            var context = new DORMITORYEntities();
            var q = context.SP_MILDISPLAY();
            return q.ToList();
        }

        internal List<SP_NAMEWISEMILSUMMAY_Result> GetMilDisplay(int Nam)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_NAMEWISEMILSUMMAY(Nam);
            return q.ToList();
        }

        internal List<SP_DAYWISEMILSUMMARY_Result> GetDayMilsummary(DateTime SD, DateTime ED)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_DAYWISEMILSUMMARY(SD,ED);
            return q.ToList();
        }

        internal List<SP_NAMEANDDATEWISEMILSUMMARY_Result> GetNameAndDayMilSummary(DateTime SD, DateTime ED, int MN)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_NAMEANDDATEWISEMILSUMMARY(SD, ED, MN);
            return q.ToList();
        }

        internal List<SP_EXPANSESDISPLAY_Result> GetExpansesGrid()
        {
            var context = new DORMITORYEntities();
            var q = context.SP_EXPANSESDISPLAY();
            return q.ToList();
        }

        internal List<SP_EXPANSESDAYWISEDISPLAY_Result1> GetDayExpansesDetail(DateTime SD, DateTime ED)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_EXPANSESDAYWISEDISPLAY(SD, ED);
            return q.ToList();
        }

        internal List<SP_EXPANSESDAYANDNAMEWISE_Result> GetDayAndNamewiseExDetail(DateTime SD, DateTime ED, int EN)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_EXPANSESDAYANDNAMEWISE(SD, ED, EN);
            return q.ToList();
        }

        internal List<SP_PURPOSEANDDAYWISEDETAIL_Result> GetPurposeWiseDetail(DateTime SD, DateTime ED, int PN)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_PURPOSEANDDAYWISEDETAIL(SD, ED, PN);
            return q.ToList();
        }

        internal List<SP_SHOWMILDAYWISE_Result> GetTotalMil(DateTime SD, DateTime ED)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_SHOWMILDAYWISE(SD, ED);
            return q.ToList();
        }

        internal List<SP_TOTALEXPANSESDAYWISE_Result> GetTotalExpanses(DateTime SD, DateTime ED)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_TOTALEXPANSESDAYWISE(SD, ED);
            return q.ToList();
        }

        internal List<SP_NAMEANDDAYWISEMILDETAIL_Result1> GetSingelPersonMil(DateTime SD, DateTime ED, int SN)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_NAMEANDDAYWISEMILDETAIL(SD, ED, SN);
            return q.ToList();
        }

        internal List<SP_NAMEANDDAYWISEDIPOSITDETAIL_Result1> GetSingelPersonDipositMoney(DateTime SD, DateTime ED, int SN)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_NAMEANDDAYWISEDIPOSITDETAIL(SD, ED, SN);
            return q.ToList();
        }

        internal List<SP_DEPARTMENT_WISE_SUMMARY_Result> GetDepartmentWiseDetail(int dep)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_DEPARTMENT_WISE_SUMMARY(dep);
            return q.ToList();
        }

        internal List<SP_SEMESTER_WISE_SUMMARY_Result> GetSemester(int ss)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_SEMESTER_WISE_SUMMARY(ss);
            return q.ToList();
        }

        internal List<SP_SHIFT_WISE_SUMMAY_Result> GetShiftDetail(int shf)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_SHIFT_WISE_SUMMAY(shf);
            return q.ToList();
        }

        internal List<SP_GENDER_WISE_SUMAMRY_Result> GetGenderDetail(int gen)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_GENDER_WISE_SUMAMRY(gen);
            return q.ToList();
        }

        internal List<SP_GENDER_DEPARTMENT_WISE_SUMMARY_Result> GetGenderAndDepartmentDetail(int gen, int dep)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_GENDER_DEPARTMENT_WISE_SUMMARY(gen, dep);
            return q.ToList();
        }

        internal List<SP_SEMESTER_GENDER_WISE_SUMMARY_Result> GetSemesterAndGender(int gen, int sem)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_SEMESTER_GENDER_WISE_SUMMARY(gen, sem);
            return q.ToList();
        }

        internal List<SP_SEMESTER_DEPARTMENT_WISE_SUMMAY_Result> GetSemesterAndDepartment(int sem, int dep)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_SEMESTER_DEPARTMENT_WISE_SUMMAY(sem, dep);
            return q.ToList();
        }

        internal List<SP_SHIFT_DEPARTMENT_WISE_SUMMAY_Result> GetShiftAndDepartment(int shif, int dep)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_SHIFT_DEPARTMENT_WISE_SUMMAY(shif, dep);
            return q.ToList();
        }

        internal List<SP_SHIFT_GENDER_WISE_SUMMARY_Result> GetGenderAndShift(int gen, int shif)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_SHIFT_GENDER_WISE_SUMMARY(gen, shif);
            return q.ToList();
        }

        internal List<SP_SHIFT_SEMESTER_WISE_DETAIL_Result> GetSemesterandShift(int sem, int shif)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_SHIFT_SEMESTER_WISE_DETAIL(sem, shif);
            return q.ToList();
        }

        internal List<SP_LAST_TOTAL_AMOUNT_DAY_WISE_SYMMARY_Result> GetLastExpenses(DateTime SDate, DateTime EDate)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_LAST_TOTAL_AMOUNT_DAY_WISE_SYMMARY(SDate, EDate);
            return q.ToList();
        }

        internal List<SP_LAST_TOTAL_AMOUNT_Result> GetLastTotal(DateTime SDate, DateTime EDate)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_LAST_TOTAL_AMOUNT(SDate,EDate);
            return q.ToList();
        }

        internal List<SP_ALL_Result> GetGridViewReport(int Sem, int Shf, int Dep, int Gen)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_ALL(Sem,Shf,Dep,Gen);
            return q.ToList();
        }

        internal object GettWithdrawDetail(DateTime SD, DateTime ED, int SN)
        {
            var context = new DORMITORYEntities();
            var q = context.SP_DATE_AND_NAME_WISE_WITHDRAW_DETAIL(SD, ED, SN);
            return q.ToList();
        }
    }
}
