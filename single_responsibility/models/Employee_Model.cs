using System;


namespace single_responsibility.models
{
    public class Employee_Model
    {
        private string name;
        private string position;
        private decimal hourly_salary;
        private int hours_worked;
        private decimal salary;
        
        public Employee_Model() { }

        public string NAME
        {
            get { return name; }
            set 
            { 
                if(value == null)
                {
                    throw new ArgumentNullException("El nombre no puede ser nulo");
                }
                name = value;
            }
        }

        public string POSITION
        {
            get { return position; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("La posicion no puede ser nula");
                }
                position = value;
            }
        }

        public decimal HOURLY_SALARY
        {
            get { return  hourly_salary; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("El salario de un trabajador no puede ser cero no negativo.");
                }
                hourly_salary = value;
            }
        }

        public int HOURS_WORKED
        {
            get { return hours_worked; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Las horas trabajadas no puede ser cero o negativo.");
                }
                hours_worked = value;
            }
        }

        public decimal SALARY
        {
            get { return salary; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Fallo al cargar el salario");
                }
                salary = value;
            }
        }

    }  
}
