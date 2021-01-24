namespace Exercises.Classes
{
    public class Employee
    {
        public int EmployeeId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; set; }
        public double AnnualSalary { get; private set; }
        public string Department { get; set; }
        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }
        public Employee(int employeeID, string firstName, string lastName, double salary)
        {
            EmployeeId = employeeID;
            FirstName = firstName;
            LastName = lastName;
            AnnualSalary = salary;
        }
        public Employee()
        { }
        public void RaiseSalary(double percent)
        {
            double raiseAmount = AnnualSalary * percent / 100;
            AnnualSalary = AnnualSalary + raiseAmount;
        }
    }
}


   
