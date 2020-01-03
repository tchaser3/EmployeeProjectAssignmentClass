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
        public FindProjectHoursDataSet FindProjectHours(int intProjectID)
        {
            try
            {
                aFindProjectHoursDataSet = new FindProjectHoursDataSet();
                aFindProjectHoursTableAdapter = new FindProjectHoursDataSetTableAdapters.FindProjectHoursTableAdapter();
                aFindProjectHoursTableAdapter.Fill(aFindProjectHoursDataSet.FindProjectHours, intProjectID);
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
