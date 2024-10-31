using single_responsibility.models;


namespace single_responsibility.controllers
{
    public class Employee_Controller
    {
        private static List<Employee_Model> employees = new List<Employee_Model>();

        public static Employee_Model createEmployee(string name, string position, string hourly_salary, string hours_worked)
        {
            try
            {
                decimal parsedSalary = parseSalary(hourly_salary);
                int parsedHoursWorked = validateHoursWorked(hours_worked);
                Employee_Model newEmployee = new();
                newEmployee.NAME = name;
                newEmployee.POSITION = position;
                newEmployee.HOURLY_SALARY = parsedSalary;
                newEmployee.HOURS_WORKED = parsedHoursWorked;
                newEmployee.SALARY = parsedSalary * parsedHoursWorked;
                employees.Add(newEmployee);
                MessageBox.Show("Empleado creado exitosamente");
                return newEmployee;
            }
            catch (Exception ex) { throw; }
        }


        public static int validateHoursWorked(string hours_worked)
        {
            return int.Parse(hours_worked);
        }

        public static decimal parseSalary(string hourly_salary)
        {
            return decimal.Parse(hourly_salary);
        }

        public static List<Employee_Model> GetAllEmployees()
        {
            return employees;
        }

    }
}
