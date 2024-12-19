using EmployeeCRUD.Models;

namespace EmployeeCRUD.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private static List<Employee> _employee;

        static EmployeeRepository()
        {
            _employee = new List<Employee>();
            _employee.Add(new Employee { EmpId=1,Name="Shivankit",City="Delhi",Salary=10000});
            _employee.Add(new Employee { EmpId=2,Name="Fiza",City="Meeruut",Salary=20000});
            _employee.Add(new Employee { EmpId=3,Name="Nakul",City="Noida",Salary=30000});
        }

        public void CreateEmployee(Employee emp)
        {
            _employee.Add(emp);

        }

        public void DeleteEmployee(int id)
        {
           var deleteEmployee = _employee.First(e=>e.EmpId==id);
           _employee.Remove(deleteEmployee);
        }

        public List<Employee> GetAll()
        {
            return _employee;
        }

        public Employee GetById(int id)
        {
            var employee =  _employee.First(e=>e.EmpId==id);
            return employee;
        }

        public void UpdateEmployee(Employee emp)
        {
            var updateEmployee = _employee.First(e => e.EmpId == emp.EmpId);
            updateEmployee.Name = emp.Name;
            updateEmployee.City = emp.City;
            updateEmployee.Salary = emp.Salary;
        }
    }
}
