using CassidyBookStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassidyBookStore.DAO
{
    public class ExpenseDAO
    {
        private static ExpenseDAO instance;

        public static ExpenseDAO Instance
        {
            get { if (instance == null) instance = new ExpenseDAO(); return ExpenseDAO.instance; }
            private set => instance = value;
        }

        private ExpenseDAO() { }

        public bool InsertExpense(string title, float amount, string date, string description)
        {
            string query = string.Format("INSERT INTO EXPENSES(TITLE,AMOUNT,DATE,DESCRIPTION) VALUES('{0}',{1},'{2}','{3}')", title, amount, date, description);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateExpense(string title, float amount, string date, string description, int id)
        {
            if (title != "")
            {
                string query = string.Format("UPDATE EXPENSES SET TITLE ='{0}', AMOUNT = {1}, DATE ='{2}', DESCRIPTION ='{3}' WHERE ID = {4}", title, amount, date, description,id);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }

            return false;
        }
        public bool DeleteExpense(int ID)
        {            
            string query = "DELETE FROM EXPENSES WHERE ID = " + ID;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<Expense> SearchExpenseByName(string name)
        {
            List<Expense> list = new List<Expense>();

            string query = string.Format("SELECT ID,TITLE,AMOUNT, DATE, DESCRIPTION FROM EXPENSES WHERE TITLE LIKE '%{0}%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Expense expense = new Expense(item);
                list.Add(expense);
            }
            return list;
        }

        public float GetTotalExpense()
        {
            string query = "SELECT SUM(AMOUNT) FROM EXPENSES";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return float.Parse(result.ToString());
        }

        public float GetThisMonthExpenses(string month)
        {
            float num = 0;
            string query = string.Format("SELECT SUM(AMOUNT) FROM EXPENSES WHERE MONTH(DATE) = {0} AND YEAR(DATE) = YEAR(GETDATE())", month);
            object result = DataProvider.Instance.ExecuteScalar(query);
            if (result != null && float.TryParse(result.ToString(), out num))
                return num;
            return 0;                
        }

        public float GetYearExpenses(string year)
        {
            float num = 0;
            string query = "SELECT SUM(AMOUNT) FROM EXPENSES WHERE YEAR(DATE) = " + year;
            object result = DataProvider.Instance.ExecuteScalar(query);
            if (result != null && float.TryParse(result.ToString(), out num))
                return num;
            return 0;
        }


    }
}