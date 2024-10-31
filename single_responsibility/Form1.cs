using single_responsibility.controllers;

namespace single_responsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupDataGridView();
            RefreshEmployeeData();
        }

        private void SetupDataGridView()
        {
            dataGridViewEmployees.AutoGenerateColumns = true;
        }

        private void RefreshEmployeeData()
        {
            dataGridViewEmployees.DataSource = null;
            dataGridViewEmployees.DataSource = Employee_Controller.GetAllEmployees();
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string position = txtPosition.Text;
            string hourly_salary = txtHourlySalary.Text;
            string hours_worked = txtHoursWorked.Text;
            try
            {
                Employee_Controller.createEmployee(name, position, hourly_salary, hours_worked);
                RefreshEmployeeData();
                txtName.Clear();
                txtPosition.Clear();
                txtHourlySalary.Clear();
                txtHoursWorked.Clear();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }


    }
}
