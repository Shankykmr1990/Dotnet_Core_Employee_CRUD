using EmployeeCRUD.Models;

namespace EmployeeCRUD.Repository
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetAll();
        public Employee GetById(int id);
        public void CreateEmployee(Employee emp);
        public void UpdateEmployee(Employee emp);
        public void DeleteEmployee(int id);
    }
}
