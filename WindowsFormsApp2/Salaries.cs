using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Salaries : Form
    {
        Functions Con;
        public Salaries()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSalary();
            GetEmployees();
        }
        private void GetEmployees()
        {
            string Query = "select * From EmployeeTab ";
            EmpCb.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
            EmpCb.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
            EmpCb.DataSource = Con.GetData(Query);
        }
        int DSal = 0;
        string Period = "";
        private void GetSalary()
        {
            string Query = "select * from EmployeeTab where EmpId = {0}";
            Query = String.Format(Query, EmpCb.SelectedValue.ToString());
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                DSal = Convert.ToInt32(dr["EmpSal"].ToString());
            }
            MessageBox.Show("" + DSal);
            // EmpCb.DataSource = Con.GetData(Query);

            if (DaysTb.Text == "")
            {
                AmountTb.Text = "Rs " + (d * DSal);
            }

            else
            {
                d = Convert.ToInt32(DaysTb.Text);
                AmountTb.Text = "Rs " + (d * DSal);
            }
        }
        private void ShowSalary()
        {
            try
            {
                string Query = "Select * From SalaryTbl";
                SalaryList.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }

        }
        int d = 1;
        private void SalaryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (EmpCb.SelectedIndex == -1 || DaysTb.Text == "" || PeriodTb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    Period = PeriodTb.Value.Date.Month.ToString() + "-" + PeriodTb.Value.Date.Year.ToString();
                    int Amount = DSal * Convert.ToInt32(DaysTb.Text);

                    int Days = Convert.ToInt32(DaysTb.Text);



                    string Query = "Insert into SalaryTbl values({0},{1},'{2}',{3},'{4}')";
                    Query = string.Format(Query, EmpCb.SelectedValue.ToString(), Days, Period, Amount, DateTime.Today.Date);
                    Con.SetData(Query);
                    ShowSalary();
                    MessageBox.Show("Salary Paid!!!");
                    DaysTb.Text = "";
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void EmpCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
