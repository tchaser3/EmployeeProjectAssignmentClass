/* Title:           Employee Project Assignment Class
 * Date:            2-5-18
 * Author:          Terry Holmes
 * 
 * Description:     This class is for Employee Assignment*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace EmployeeProjectAssignmentDLL
{
    public class EmployeeProjectAssignmentClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();

        EmployeeProjectAssignmentDataSet aEmployeeProjectAssignmentDataSet;
        EmployeeProjectAssignmentDataSetTableAdapters.employeeprojectassignmentTableAdapter aEmployeeProjectAssignmentTableAdapter;

        InsertEmployeeProjectAssignmentEntryTableAdapters.QueriesTableAdapter aInsertEmployeeProjectAssignmentTableAdapter;

        UpdateEmployeeProjectAssignmentEntryTableAdapters.QueriesTableAdapter aUpdateEmployeeProjectAssignmentTableAdapter;

        FindEmployeeHoursOverDateRangeDataSet aFindEmployeeHoursOverDateRangeDataSet;
        FindEmployeeHoursOverDateRangeDataSetTableAdapters.FindEmployeeHoursOverDateRangeTableAdapter aFindEmployeeHoursOverDateRangeTableAdapter;

        FindProjectHoursDataSet aFindProjectHoursDataSet;
        FindProjectHoursDataSetTableAdapters.FindProjectHoursTableAdapter aFindProjectHoursTableAdapter;

        FindLaborHoursByDateRangeDataSet aFindLaborHoursByDateRangeDataSet;
        FindLaborHoursByDateRangeDataSetTableAdapters.FindLaborHoursByDateRangeTableAdapter aFindLaborHoursByDateRangeTableAdapter;

        FindProjectHoursSpecificDateAndEmployeeDataSet aFindProjectHoursSpecificDateAndEmployeeDataSet;
        FindProjectHoursSpecificDateAndEmployeeDataSetTableAdapters.FindProjectHoursSpecificDateAndEmployeeTableAdapter aFindProjectHoursSpecificDateAndEmployeeTableAdapter;

        FindEmployeeLaborByTransactionIDDataSet aFindEmployeeLaborByTransactionIDDataSet;
        FindEmployeeLaborByTransactionIDDataSetTableAdapters.FindEmployeeLaborByTransactionIDTableAdapter aFindEmployeeLaborByTransactionIDTableAdapter;

        UpdateEmployeeLaborHoursEntryTableAdapters.QueriesTableAdapter aUpdateEmployeeLaborHoursTableAdapter;

        FindEmployeeProjectHoursOverDateRangeDataSet aFindEmployeeProjectHoursOverDateRangeDataSet;
        FindEmployeeProjectHoursOverDateRangeDataSetTableAdapters.FindEmployeeProjectHoursOverDateRangeTableAdapter aFindEmployeeProjectHoursOverDateRangeTableAdapter;

        FindEmployeeTaskHoursByEmployeeIDDataSet aFindEmployeeTaskHoursByEmployeeIDDataSet;
        FindEmployeeTaskHoursByEmployeeIDDataSetTableAdapters.FindEmployeeTaskHoursByEmployeeIDTableAdapter aFindEmployeeTaskHoursByEmployeeIDTableAdapter;

        FindEmployeeProjectAssignmentByTaskIDDataSet aFindEmployeeProjectAssignmentByTaskIDDataSet;
        FindEmployeeProjectAssignmentByTaskIDDataSetTableAdapters.FindEmployeeProjectAssignmentByTaskIDTableAdapter aFindEmployeeProjectAssignmentByTaskIDTableAdapter;

        UpdateEmployeeProjectAssignmentTaskIDEntryTableAdapters.QueriesTableAdapter aUpdateEmployeeProjectAssignmentTaskIDTableAdapter;

        FindEmployeeProductionHoursOverPayPeriodDataSet aFindEmployeeProductionHoursOverPayPeriodDataSet;
        FindEmployeeProductionHoursOverPayPeriodDataSetTableAdapters.FindEmployeeProductionHoursOverPayPeriodTableAdapter aFindEmployeeProductionHoursOverPayPeriodTableAdapter;

        FindEmployeeTaskTotalHoursDataSet aFindEmployeeTaskTotalHoursDataSet;
        FindEmployeeTaskTotalHoursDataSetTableAdapters.FindEmployeeTaskTotalHoursTableAdapter aFindEmployeeTaskTotalHoursTableAdapter;

        ProductivityNotCorrectDataSet aProductivityNotCorrectDataSet;
        ProductivityNotCorrectDataSetTableAdapters.productivitynotcorrectTableAdapter aProductivityNotCorrectTableAdapter;

        InsertProductivityNotCorrectEntryTableAdapters.QueriesTableAdapter aInsertProductivityNotCorrectTableAdapter;

        FindProductivityNotCorrectDataSet aFindProductivityNotCorrectDataSet;
        FindProductivityNotCorrectDataSetTableAdapters.FindProductivityNotCorrectTableAdapter aFindProductivityNotCorrectTableAdapter;

        FindProductivityManagersForEmailDataSet aFindProductivityManagersForEmailDataSet;
        FindProductivityManagersForEmailDataSetTableAdapters.FindProductivityManagersForEmailTableAdapter aFindProductivityManagersForEmailTableAdapter;

        FindProjectHoursTotalDataSet aFindProjectHoursTotalDataSet;
        FindProjectHoursTotalDataSetTableAdapters.FindProjectHourTotalsTableAdapter aFindProjectHoursTotalTableAdapter;

        FindAllProjectProductivityCostsOverDateRangeDataSet aFindAllProjectProductivityCostsOverDateRangeDataSet;
        FindAllProjectProductivityCostsOverDateRangeDataSetTableAdapters.FindAllProjectProductivityCostsOverDateRangeTableAdapter aFindAllProjectProductivityCostsOverDateRangeTableAdapter;

        FindAllEmployeeProductionOverAWeekDataSet aFindAllEmployeeProductionOverAWeekDataSet;
        FindAllEmployeeProductionOverAWeekDataSetTableAdapters.FindAllEmployeeProductionOverAWeekTableAdapter aFindAllEmployeeProductionOverAWeekTableAdapter;

        FindProjectHoursAboveLimitDataSet aFindProjectHoursAboveLimitDataSet;
        FindProjectHoursAboveLimitDataSetTableAdapters.FindProjectHoursAboveLimitTableAdapter aFindProjectHoursAboveLimitTableAdapter;

        FindProductivitySheetForVoidingDataSet aFindProductivitySheetForVoidingDataSet;
        FindProductivitySheetForVoidingDataSetTableAdapters.FindProductivitySheetForVoidingTableAdapter aFindProductivitySheetForVoidingTableAdapter;

        FindDriveTimeForVoidingDataSet aFindDriveTimeForVoidingDataSet;
        FindDriveTimeForVoidingDataSetTableAdapters.FindDriveTimeForVoidingTableAdapter aFindDriveTimeForVoidingTableAdapter;

        FindDetailEmployeeProductivityOverDateRangeDataSet aFindDetailEmployeeProductivityOverDateRangeDataSet;
        FindDetailEmployeeProductivityOverDateRangeDataSetTableAdapters.FindDetailEmployeeProductivityOverDateRangeTableAdapter aFindDetailEmployeeProductivityOverDateRangeTableAdapter;

        FindEmployeeProductionForMiscCodeDataSet aFindEmployeeProductionForMiscCodeDataSet;
        FindEmployeeProductionForMiscCodeDataSetTableAdapters.FindEmployeeProductionForMiscCodeTableAdapter aFindEmployeeProductionForMiscCodeTableAdpater;

        FindEmployeeProductivityMiscTotalHoursDataSet aFindEmployeeProductivityMiscTotalhoursDataSet;
        FindEmployeeProductivityMiscTotalHoursDataSetTableAdapters.FindEmployeeProductivityMiscTotalHoursTableAdapter aFindEmployeeProductivityMiscTotalHoursTableAdpater;

        FindEmployeeProjectAssignmentDriveTimeHoursDataSet aFindEmployeeProjectAssignmentDriveTimeHoursDataSet;
        FindEmployeeProjectAssignmentDriveTimeHoursDataSetTableAdapters.FindEmployeeProjectAssignmentDriveTimeHoursTableAdapter aFindEmployeeProjectAssignmentDriveTimeHoursTableAdapter;

        FindEmployeeProjectAssignmentForComparisonDataSet aFindEmployeeProjectAssignmentForComparisonDataSet;
        FindEmployeeProjectAssignmentForComparisonDataSetTableAdapters.FindEmployeeProjectAssignmentforComparisonTableAdapter aFindEmployeeProjectAssignmentForComparisonTableAdapter;

        FindEmployeeProjectAssignmentForProductivityDataSet aFindEmployeeProjectAssignmentForProductivityDataSet;
        FindEmployeeProjectAssignmentForProductivityDataSetTableAdapters.FindEmployeeProjectAssignmentForProductivityTableAdapter aFindEmployeeProjectAssignmentForProductivityTableAdapter;

        FindEmployeeProjectAssignmentForVoidingDataSet aFindEmployeeProjectAssignmentForVoidingDataSet;
        FindEmployeeProjectAssignmentForVoidingDataSetTableAdapters.FindEmployeeProjectAssignmentForVoidingTableAdapter aFindEmployeeProjectAssignmentForVoidingTableAdapter;

        FindProjectProductionByAssignedProjectIDDataSet aFindProjectProductionByAssignedProjectIDDataSet;
        FindProjectProductionByAssignedProjectIDDataSetTableAdapters.FindProjectProductionByAssignedProjectIDTableAdapter aFindProjectProductionByAssignedProjectIDTableAdapter;

        FindProjectProductionCostsByProjectIDDataSet aFindProjectProductionCostsByProjectIDDataSet;
        FindProjectProductionCostsByProjectIDDataSetTableAdapters.FindProjectProductionCostsByProjectIDTableAdapter aFindProjectProductionCostsByProjectIDTableAdapter;

        FindProjectProductivityDataSet aFindProjectProductivityDataSet;
        FindProjectProductivityDataSetTableAdapters.FindProjectProductivityTableAdapter aFindProjectProductivityTableAdapter;

        FindEmployeeProjectAssignmentForAllDataSet aFindEmployeeProjectAssignmentForAllDataSet;
        FindEmployeeProjectAssignmentForAllDataSetTableAdapters.FindEmployeeProjectAssignmentForAllTableAdapter aFindEmployeeProjectAssignmentForAllTableAdapter;

        public FindEmployeeProjectAssignmentForAllDataSet FindEmployeeProjectAssignmentForAll(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindEmployeeProjectAssignmentForAllDataSet = new FindEmployeeProjectAssignmentForAllDataSet();
                aFindEmployeeProjectAssignmentForAllTableAdapter = new FindEmployeeProjectAssignmentForAllDataSetTableAdapters.FindEmployeeProjectAssignmentForAllTableAdapter();
                aFindEmployeeProjectAssignmentForAllTableAdapter.Fill(aFindEmployeeProjectAssignmentForAllDataSet.FindEmployeeProjectAssignmentForAll, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Employee Project Assignment For All " + Ex.ToString());
            }

            return aFindEmployeeProjectAssignmentForAllDataSet;
        }
        public FindProjectProductivityDataSet FindProjectProductivity(int intProjectID)
        {
            try
            {
                aFindProjectProductivityDataSet = new FindProjectProductivityDataSet();
                aFindProjectProductivityTableAdapter = new FindProjectProductivityDataSetTableAdapters.FindProjectProductivityTableAdapter();
                aFindProjectProductivityTableAdapter.Fill(aFindProjectProductivityDataSet.FindProjectProductivity, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Project Productivity Class " + Ex.ToString());
            }

            return aFindProjectProductivityDataSet;
        }
        public FindProjectProductionCostsByProjectIDDataSet FindProjectProductionCostsByProjectID(int intProjectID)
        {
            try
            {
                aFindProjectProductionCostsByProjectIDDataSet = new FindProjectProductionCostsByProjectIDDataSet();
                aFindProjectProductionCostsByProjectIDTableAdapter = new FindProjectProductionCostsByProjectIDDataSetTableAdapters.FindProjectProductionCostsByProjectIDTableAdapter();
                aFindProjectProductionCostsByProjectIDTableAdapter.Fill(aFindProjectProductionCostsByProjectIDDataSet.FindProjectProductionCostsByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Production Project Costs By Project ID " + Ex.Message);
            }

            return aFindProjectProductionCostsByProjectIDDataSet;
        }
        public FindProjectProductionByAssignedProjectIDDataSet FindProjectProductionByAssignedProjectID(string strAssignedProjectID)
        {
            try
            {
                aFindProjectProductionByAssignedProjectIDDataSet = new FindProjectProductionByAssignedProjectIDDataSet();
                aFindProjectProductionByAssignedProjectIDTableAdapter = new FindProjectProductionByAssignedProjectIDDataSetTableAdapters.FindProjectProductionByAssignedProjectIDTableAdapter();
                aFindProjectProductionByAssignedProjectIDTableAdapter.Fill(aFindProjectProductionByAssignedProjectIDDataSet.FindProjectProductionByAssignedProjectID, strAssignedProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Project Production By Assigned Project ID " + Ex.Message);
            }

            return aFindProjectProductionByAssignedProjectIDDataSet;
        }
        public FindEmployeeProjectAssignmentForVoidingDataSet FindEmployeeProjectAssignmentForVoiding(int intEmployeeID, DateTime datTransactionDate)
        {
            try
            {
                aFindEmployeeProjectAssignmentForVoidingDataSet = new FindEmployeeProjectAssignmentForVoidingDataSet();
                aFindEmployeeProjectAssignmentForVoidingTableAdapter = new FindEmployeeProjectAssignmentForVoidingDataSetTableAdapters.FindEmployeeProjectAssignmentForVoidingTableAdapter();
                aFindEmployeeProjectAssignmentForVoidingTableAdapter.Fill(aFindEmployeeProjectAssignmentForVoidingDataSet.FindEmployeeProjectAssignmentForVoiding, intEmployeeID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find EmployeeProjectAssignmentForVoiding " + Ex.Message);
            }

            return aFindEmployeeProjectAssignmentForVoidingDataSet;
        }
        public FindEmployeeProjectAssignmentForProductivityDataSet FindEmployeeProjectAssignmentForProductivity(int intEmployeeID, int intProjectID, int intWorkTaskID, DateTime datTransactionDate)
        {
            try
            {
                aFindEmployeeProjectAssignmentForProductivityDataSet = new FindEmployeeProjectAssignmentForProductivityDataSet();
                aFindEmployeeProjectAssignmentForProductivityTableAdapter = new FindEmployeeProjectAssignmentForProductivityDataSetTableAdapters.FindEmployeeProjectAssignmentForProductivityTableAdapter();
                aFindEmployeeProjectAssignmentForProductivityTableAdapter.Fill(aFindEmployeeProjectAssignmentForProductivityDataSet.FindEmployeeProjectAssignmentForProductivity, intEmployeeID, intProjectID, intWorkTaskID, datTransactionDate);
            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Employee Project Assignment For Productivity " + Ex.Message);
            }

            return aFindEmployeeProjectAssignmentForProductivityDataSet;
        }
        public FindEmployeeProjectAssignmentForComparisonDataSet FindEmployeeProjectAssignmentForComparison(int intEmployeeID, int intProjectID, DateTime datTransactionDate)
        {
            try
            {
                aFindEmployeeProjectAssignmentForComparisonDataSet = new FindEmployeeProjectAssignmentForComparisonDataSet();
                aFindEmployeeProjectAssignmentForComparisonTableAdapter = new FindEmployeeProjectAssignmentForComparisonDataSetTableAdapters.FindEmployeeProjectAssignmentforComparisonTableAdapter();
                aFindEmployeeProjectAssignmentForComparisonTableAdapter.Fill(aFindEmployeeProjectAssignmentForComparisonDataSet.FindEmployeeProjectAssignmentforComparison, intEmployeeID, intProjectID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment // Find Employee Project Assignment For Comparison " + Ex.Message);
            }

            return aFindEmployeeProjectAssignmentForComparisonDataSet;
        }
        public FindEmployeeProjectAssignmentDriveTimeHoursDataSet FindEmployeeProjectAssignmentDriveTimeHours()
        {
            try
            {
                aFindEmployeeProjectAssignmentDriveTimeHoursDataSet = new FindEmployeeProjectAssignmentDriveTimeHoursDataSet();
                aFindEmployeeProjectAssignmentDriveTimeHoursTableAdapter = new FindEmployeeProjectAssignmentDriveTimeHoursDataSetTableAdapters.FindEmployeeProjectAssignmentDriveTimeHoursTableAdapter();
                aFindEmployeeProjectAssignmentDriveTimeHoursTableAdapter.Fill(aFindEmployeeProjectAssignmentDriveTimeHoursDataSet.FindEmployeeProjectAssignmentDriveTimeHours);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Employee Project Assignment Drive Time Hours " + Ex.Message);
            }

            return aFindEmployeeProjectAssignmentDriveTimeHoursDataSet;
        }
        public FindEmployeeProductivityMiscTotalHoursDataSet FindEmplolyeeProductivityMiscTotalHours()
        {
            try
            {
                aFindEmployeeProductivityMiscTotalhoursDataSet = new FindEmployeeProductivityMiscTotalHoursDataSet();
                aFindEmployeeProductivityMiscTotalHoursTableAdpater = new FindEmployeeProductivityMiscTotalHoursDataSetTableAdapters.FindEmployeeProductivityMiscTotalHoursTableAdapter();
                aFindEmployeeProductivityMiscTotalHoursTableAdpater.Fill(aFindEmployeeProductivityMiscTotalhoursDataSet.FindEmployeeProductivityMiscTotalHours);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment // Find Employee Productivity " + Ex.Message); 
            }

            return aFindEmployeeProductivityMiscTotalhoursDataSet;
        }
        public FindEmployeeProductionForMiscCodeDataSet FindEmployeeProductionForMiscCode()
        {
            try
            {
                aFindEmployeeProductionForMiscCodeDataSet = new FindEmployeeProductionForMiscCodeDataSet();
                aFindEmployeeProductionForMiscCodeTableAdpater = new FindEmployeeProductionForMiscCodeDataSetTableAdapters.FindEmployeeProductionForMiscCodeTableAdapter();
                aFindEmployeeProductionForMiscCodeTableAdpater.Fill(aFindEmployeeProductionForMiscCodeDataSet.FindEmployeeProductionForMiscCode);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Employee Production For Misc Code " + Ex.Message);
            }

            return aFindEmployeeProductionForMiscCodeDataSet;
        }
        public FindDetailEmployeeProductivityOverDateRangeDataSet FindDetailEmployeeProductivityOverDateRange(int intEmployee, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDetailEmployeeProductivityOverDateRangeDataSet = new FindDetailEmployeeProductivityOverDateRangeDataSet();
                aFindDetailEmployeeProductivityOverDateRangeTableAdapter = new FindDetailEmployeeProductivityOverDateRangeDataSetTableAdapters.FindDetailEmployeeProductivityOverDateRangeTableAdapter();
                aFindDetailEmployeeProductivityOverDateRangeTableAdapter.Fill(aFindDetailEmployeeProductivityOverDateRangeDataSet.FindDetailEmployeeProductivityOverDateRange, intEmployee, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment // Find Detail Employee Productivity Over Date Range " + Ex.Message);
            }

            return aFindDetailEmployeeProductivityOverDateRangeDataSet;
        }
        public FindDriveTimeForVoidingDataSet FindDriveTimeForVoiding(DateTime datTransactionDate, int intEmployeeID, int intProjectID)
        {
            try
            {
                aFindDriveTimeForVoidingDataSet = new FindDriveTimeForVoidingDataSet();
                aFindDriveTimeForVoidingTableAdapter = new FindDriveTimeForVoidingDataSetTableAdapters.FindDriveTimeForVoidingTableAdapter();
                aFindDriveTimeForVoidingTableAdapter.Fill(aFindDriveTimeForVoidingDataSet.FindDriveTimeForVoiding, datTransactionDate, intEmployeeID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Drive Time For Voiding " + Ex.Message);
            }

            return aFindDriveTimeForVoidingDataSet;
        }
        public FindProductivitySheetForVoidingDataSet FindProductivitySheetForVoiding(int intProjectID, DateTime datTransactionDate)
        {
            try
            {
                aFindProductivitySheetForVoidingDataSet = new FindProductivitySheetForVoidingDataSet();
                aFindProductivitySheetForVoidingTableAdapter = new FindProductivitySheetForVoidingDataSetTableAdapters.FindProductivitySheetForVoidingTableAdapter();
                aFindProductivitySheetForVoidingTableAdapter.Fill(aFindProductivitySheetForVoidingDataSet.FindProductivitySheetForVoiding, intProjectID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Productivity Sheet For Voiding " + Ex.Message);
            }

            return aFindProductivitySheetForVoidingDataSet;
        }
        public FindProjectHoursAboveLimitDataSet FindProjectHoursAboveLimit(int intProjectID, DateTime datStartDate, decimal decUpperLimit)
        {
            try
            {
                aFindProjectHoursAboveLimitDataSet = new FindProjectHoursAboveLimitDataSet();
                aFindProjectHoursAboveLimitTableAdapter = new FindProjectHoursAboveLimitDataSetTableAdapters.FindProjectHoursAboveLimitTableAdapter();
                aFindProjectHoursAboveLimitTableAdapter.Fill(aFindProjectHoursAboveLimitDataSet.FindProjectHoursAboveLimit, intProjectID, datStartDate, decUpperLimit);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignement Class // Find Project Hours Above Limit " + Ex.Message);
            }

            return aFindProjectHoursAboveLimitDataSet;
        }
        public FindAllEmployeeProductionOverAWeekDataSet FindAllEmployeeProductionOverAWeek(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindAllEmployeeProductionOverAWeekDataSet = new FindAllEmployeeProductionOverAWeekDataSet();
                aFindAllEmployeeProductionOverAWeekTableAdapter = new FindAllEmployeeProductionOverAWeekDataSetTableAdapters.FindAllEmployeeProductionOverAWeekTableAdapter();
                aFindAllEmployeeProductionOverAWeekTableAdapter.Fill(aFindAllEmployeeProductionOverAWeekDataSet.FindAllEmployeeProductionOverAWeek, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment // Find All Employee Production Over a Week " + Ex.Message);
            }

            return aFindAllEmployeeProductionOverAWeekDataSet;
        }
        public FindAllProjectProductivityCostsOverDateRangeDataSet FindAllProjectProductivityCostsOverDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindAllProjectProductivityCostsOverDateRangeDataSet = new FindAllProjectProductivityCostsOverDateRangeDataSet();
                aFindAllProjectProductivityCostsOverDateRangeTableAdapter = new FindAllProjectProductivityCostsOverDateRangeDataSetTableAdapters.FindAllProjectProductivityCostsOverDateRangeTableAdapter();
                aFindAllProjectProductivityCostsOverDateRangeTableAdapter.Fill(aFindAllProjectProductivityCostsOverDateRangeDataSet.FindAllProjectProductivityCostsOverDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignement Class // Find All Project Productivity Costs Over Date Range " + Ex.Message);
            }

            return aFindAllProjectProductivityCostsOverDateRangeDataSet;
        }
        public FindProjectHoursTotalDataSet FindProjectHoursTotal(int intProjectID)
        {
            try
            {
                aFindProjectHoursTotalDataSet = new FindProjectHoursTotalDataSet();
                aFindProjectHoursTotalTableAdapter = new FindProjectHoursTotalDataSetTableAdapters.FindProjectHourTotalsTableAdapter();
                aFindProjectHoursTotalTableAdapter.Fill(aFindProjectHoursTotalDataSet.FindProjectHourTotals, intProjectID);
            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment // Find Project Total Hours " + Ex.Message);
            }

            return aFindProjectHoursTotalDataSet;
        }
        public FindProductivityManagersForEmailDataSet FindProductivityManagersForEmail()
        {
            try
            {
                aFindProductivityManagersForEmailDataSet = new FindProductivityManagersForEmailDataSet();
                aFindProductivityManagersForEmailTableAdapter = new FindProductivityManagersForEmailDataSetTableAdapters.FindProductivityManagersForEmailTableAdapter();
                aFindProductivityManagersForEmailTableAdapter.Fill(aFindProductivityManagersForEmailDataSet.FindProductivityManagersForEmail);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Productivity Managers For Email " + Ex.Message);
            }

            return aFindProductivityManagersForEmailDataSet;
        }
        public FindProductivityNotCorrectDataSet FindProductivityNotCorrect(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindProductivityNotCorrectDataSet = new FindProductivityNotCorrectDataSet();
                aFindProductivityNotCorrectTableAdapter = new FindProductivityNotCorrectDataSetTableAdapters.FindProductivityNotCorrectTableAdapter();
                aFindProductivityNotCorrectTableAdapter.Fill(aFindProductivityNotCorrectDataSet.FindProductivityNotCorrect, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Productivity Not Correct " + Ex.Message);
            } 

            return aFindProductivityNotCorrectDataSet;
        }
        public bool InsertProductivityNotCorrect(int intEmployeeID, DateTime datTransactionDate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductivityNotCorrectTableAdapter = new InsertProductivityNotCorrectEntryTableAdapters.QueriesTableAdapter();
                aInsertProductivityNotCorrectTableAdapter.InsertProductivityNotCorrect(intEmployeeID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Insert Productivity Not Correct " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProductivityNotCorrectDataSet GetProductivityNotCorrectInfo()
        {
            try
            {
                aProductivityNotCorrectDataSet = new ProductivityNotCorrectDataSet();
                aProductivityNotCorrectTableAdapter = new ProductivityNotCorrectDataSetTableAdapters.productivitynotcorrectTableAdapter();
                aProductivityNotCorrectTableAdapter.Fill(aProductivityNotCorrectDataSet.productivitynotcorrect);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Get Productivity Not Correct Info " + Ex.Message);
            }

            return aProductivityNotCorrectDataSet;
        }
        public void UpdateProductivityNotCorrectDB(ProductivityNotCorrectDataSet aProductivityNotCorrectDataSet)
        {
            try
            {
                aProductivityNotCorrectTableAdapter = new ProductivityNotCorrectDataSetTableAdapters.productivitynotcorrectTableAdapter();
                aProductivityNotCorrectTableAdapter.Update(aProductivityNotCorrectDataSet.productivitynotcorrect);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Update Productivity Not Correct DB " + Ex.Message);
            }
        }
        public FindEmployeeTaskTotalHoursDataSet FindEmployeeTaskTotalHours(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindEmployeeTaskTotalHoursDataSet = new FindEmployeeTaskTotalHoursDataSet();
                aFindEmployeeTaskTotalHoursTableAdapter = new FindEmployeeTaskTotalHoursDataSetTableAdapters.FindEmployeeTaskTotalHoursTableAdapter();
                aFindEmployeeTaskTotalHoursTableAdapter.Fill(aFindEmployeeTaskTotalHoursDataSet.FindEmployeeTaskTotalHours, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Employee Task Total Hours " + Ex.Message);
            }

            return aFindEmployeeTaskTotalHoursDataSet;
        }
        public FindEmployeeProductionHoursOverPayPeriodDataSet FindEmployeeProductionHoursOverPayPeriodDataSet(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindEmployeeProductionHoursOverPayPeriodDataSet = new FindEmployeeProductionHoursOverPayPeriodDataSet();
                aFindEmployeeProductionHoursOverPayPeriodTableAdapter = new FindEmployeeProductionHoursOverPayPeriodDataSetTableAdapters.FindEmployeeProductionHoursOverPayPeriodTableAdapter();
                aFindEmployeeProductionHoursOverPayPeriodTableAdapter.Fill(aFindEmployeeProductionHoursOverPayPeriodDataSet.FindEmployeeProductionHoursOverPayPeriod, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment // Find Employee Production Hours Over Pay Period " + Ex.Message);
            }

            return aFindEmployeeProductionHoursOverPayPeriodDataSet;
        }
        public bool UpdateEmployeeProjectAssignmentTaskID(int intTransactionID, int intTaskID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateEmployeeProjectAssignmentTaskIDTableAdapter = new UpdateEmployeeProjectAssignmentTaskIDEntryTableAdapters.QueriesTableAdapter();
                aUpdateEmployeeProjectAssignmentTaskIDTableAdapter.UpdateEmployeeProjectAssignmentTaskID(intTransactionID, intTaskID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Update Employee Project Assignment Task ID " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindEmployeeProjectAssignmentByTaskIDDataSet FindEmployeeProjectAssignementByTaskID(int intTaskID)
        {
            try
            {
                aFindEmployeeProjectAssignmentByTaskIDDataSet = new FindEmployeeProjectAssignmentByTaskIDDataSet();
                aFindEmployeeProjectAssignmentByTaskIDTableAdapter = new FindEmployeeProjectAssignmentByTaskIDDataSetTableAdapters.FindEmployeeProjectAssignmentByTaskIDTableAdapter();
                aFindEmployeeProjectAssignmentByTaskIDTableAdapter.Fill(aFindEmployeeProjectAssignmentByTaskIDDataSet.FindEmployeeProjectAssignmentByTaskID, intTaskID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee project Assignment Class // Find Employee Project Assignement By Task ID " + Ex.Message);
            }

            return aFindEmployeeProjectAssignmentByTaskIDDataSet;
        }
        public FindEmployeeTaskHoursByEmployeeIDDataSet FindEmployeeTaskHoursByEmployeeID(int intEmployeeID, DateTime datStartDate,  DateTime datEndDate)
        {
            try
            {
                aFindEmployeeTaskHoursByEmployeeIDDataSet = new FindEmployeeTaskHoursByEmployeeIDDataSet();
                aFindEmployeeTaskHoursByEmployeeIDTableAdapter = new FindEmployeeTaskHoursByEmployeeIDDataSetTableAdapters.FindEmployeeTaskHoursByEmployeeIDTableAdapter();
                aFindEmployeeTaskHoursByEmployeeIDTableAdapter.Fill(aFindEmployeeTaskHoursByEmployeeIDDataSet.FindEmployeeTaskHoursByEmployeeID, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Employee Task Hours By Employee ID " + Ex.Message);
            }

            return aFindEmployeeTaskHoursByEmployeeIDDataSet;
        }
        public FindEmployeeProjectHoursOverDateRangeDataSet FindEmployeeProjectHoursOverDateRange(int intEmployeeID, int intProjectID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindEmployeeProjectHoursOverDateRangeDataSet = new FindEmployeeProjectHoursOverDateRangeDataSet();
                aFindEmployeeProjectHoursOverDateRangeTableAdapter = new FindEmployeeProjectHoursOverDateRangeDataSetTableAdapters.FindEmployeeProjectHoursOverDateRangeTableAdapter();
                aFindEmployeeProjectHoursOverDateRangeTableAdapter.Fill(aFindEmployeeProjectHoursOverDateRangeDataSet.FindEmployeeProjectHoursOverDateRange, intEmployeeID, intProjectID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Employee Project Hours Over Date Range " + Ex.Message);
            }

            return aFindEmployeeProjectHoursOverDateRangeDataSet;
        }
        public bool UpdateEmployeeLaborHours(int intTransactionID, decimal decHours)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateEmployeeLaborHoursTableAdapter = new UpdateEmployeeLaborHoursEntryTableAdapters.QueriesTableAdapter();
                aUpdateEmployeeLaborHoursTableAdapter.UpdateEmployeeLaborHours(intTransactionID, decHours);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Update Employee Labor Hours " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindEmployeeLaborByTransactionIDDataSet FindEmployeeLaborByTransactionID(int intTransactionID)
        {
            try
            {
                aFindEmployeeLaborByTransactionIDDataSet = new FindEmployeeLaborByTransactionIDDataSet();
                aFindEmployeeLaborByTransactionIDTableAdapter = new FindEmployeeLaborByTransactionIDDataSetTableAdapters.FindEmployeeLaborByTransactionIDTableAdapter();
                aFindEmployeeLaborByTransactionIDTableAdapter.Fill(aFindEmployeeLaborByTransactionIDDataSet.FindEmployeeLaborByTransactionID, intTransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Employee Labor By Transaction ID " + Ex.Message);
            }

            return aFindEmployeeLaborByTransactionIDDataSet;
        }
        public FindProjectHoursSpecificDateAndEmployeeDataSet FindProjectHoursSpecificDateAndEmployee(int intProjectID, int intEmployeeID, DateTime datTransactionDate)
        {
            try
            {
                aFindProjectHoursSpecificDateAndEmployeeDataSet = new FindProjectHoursSpecificDateAndEmployeeDataSet();
                aFindProjectHoursSpecificDateAndEmployeeTableAdapter = new FindProjectHoursSpecificDateAndEmployeeDataSetTableAdapters.FindProjectHoursSpecificDateAndEmployeeTableAdapter();
                aFindProjectHoursSpecificDateAndEmployeeTableAdapter.Fill(aFindProjectHoursSpecificDateAndEmployeeDataSet.FindProjectHoursSpecificDateAndEmployee, intProjectID, intEmployeeID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Project Hours Specific Date and Employee " + Ex.Message);
            }

            return aFindProjectHoursSpecificDateAndEmployeeDataSet;
        }
        public FindLaborHoursByDateRangeDataSet FindLaborHoursByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindLaborHoursByDateRangeDataSet = new FindLaborHoursByDateRangeDataSet();
                aFindLaborHoursByDateRangeTableAdapter = new FindLaborHoursByDateRangeDataSetTableAdapters.FindLaborHoursByDateRangeTableAdapter();
                aFindLaborHoursByDateRangeTableAdapter.Fill(aFindLaborHoursByDateRangeDataSet.FindLaborHoursByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Labor Hours By Date Range " + Ex.Message);
            }

            return aFindLaborHoursByDateRangeDataSet;
        }
        public FindProjectHoursDataSet FindProjectHours(int intProjectID, DateTime datStartDate)
        {
            try
            {
                aFindProjectHoursDataSet = new FindProjectHoursDataSet();
                aFindProjectHoursTableAdapter = new FindProjectHoursDataSetTableAdapters.FindProjectHoursTableAdapter();
                aFindProjectHoursTableAdapter.Fill(aFindProjectHoursDataSet.FindProjectHours, intProjectID, datStartDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Project Hours " + Ex.Message);
            }

            return aFindProjectHoursDataSet;
        }
        public FindEmployeeHoursOverDateRangeDataSet FindEmployeeHoursOverDateRange(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindEmployeeHoursOverDateRangeDataSet = new FindEmployeeHoursOverDateRangeDataSet();
                aFindEmployeeHoursOverDateRangeTableAdapter = new FindEmployeeHoursOverDateRangeDataSetTableAdapters.FindEmployeeHoursOverDateRangeTableAdapter();
                aFindEmployeeHoursOverDateRangeTableAdapter.Fill(aFindEmployeeHoursOverDateRangeDataSet.FindEmployeeHoursOverDateRange, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Find Employee Hours Over Date Range " + Ex.Message);
            }

            return aFindEmployeeHoursOverDateRangeDataSet;
        }
        public bool UpdateEmployeeProjectAssignment(int intTransactionID, int intEmployeeID, int intProjectID, int intTaskID, DateTime datTransactionDate, decimal decTotalHours)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateEmployeeProjectAssignmentTableAdapter = new UpdateEmployeeProjectAssignmentEntryTableAdapters.QueriesTableAdapter();
                aUpdateEmployeeProjectAssignmentTableAdapter.UpdateEmployeeProjectAssignment(intTransactionID, intEmployeeID, intProjectID, datTransactionDate, intTaskID, decTotalHours);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Insert Employee Project Assignment " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertEmployeeProjectAssignment(int intEmployeeID, int intProjectID, int intTaskID, DateTime datTransactionDate, decimal decTotalHours)
        {
            bool blnFatalError = false;

            try
            {
                aInsertEmployeeProjectAssignmentTableAdapter = new InsertEmployeeProjectAssignmentEntryTableAdapters.QueriesTableAdapter();
                aInsertEmployeeProjectAssignmentTableAdapter.InsertEmployeeProjectAssignment(intEmployeeID, intProjectID, datTransactionDate, intTaskID,  decTotalHours);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Insert Employee Project Assignment " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public EmployeeProjectAssignmentDataSet GetEmployeeProjectAssignmentInfo()
        {
            try
            {
                aEmployeeProjectAssignmentDataSet = new EmployeeProjectAssignmentDataSet();
                aEmployeeProjectAssignmentTableAdapter = new EmployeeProjectAssignmentDataSetTableAdapters.employeeprojectassignmentTableAdapter();
                aEmployeeProjectAssignmentTableAdapter.Fill(aEmployeeProjectAssignmentDataSet.employeeprojectassignment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Get Employee Project Assignment Info " + Ex.Message);
            }

            return aEmployeeProjectAssignmentDataSet;
        }
        public void UpdateEmployeeProjectAssignmentDB(EmployeeProjectAssignmentDataSet aEmployeeProjectAssignmentDataSet)
        {
            try
            {
                aEmployeeProjectAssignmentTableAdapter = new EmployeeProjectAssignmentDataSetTableAdapters.employeeprojectassignmentTableAdapter();
                aEmployeeProjectAssignmentTableAdapter.Update(aEmployeeProjectAssignmentDataSet.employeeprojectassignment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Project Assignment Class // Update Employee Project Assignment DB " + Ex.Message);
            }
        }
    }
}
