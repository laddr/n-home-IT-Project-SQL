using System.Collections.Generic;
using System.Linq;

namespace nHomeIT.Tests.EmployeeSystem.Core.Services
{
    /// <summary>
    /// Manages the list of Employees
    /// </summary>
    public class EmployeeService
    {
        #region Fields

        private readonly List<Employee> _employees;

        #endregion
        
        #region Constructors

        /// <summary>
        /// Instantiates a new Employee Service using the list of employees provided.
        /// </summary>
        /// <param name="employees">The list of employees this service will manage.</param>
        public EmployeeService(List<Employee> employees)
        {
            _employees = employees;
        }

        #endregion

        #region Public Functions

        /// <summary>
        /// Attempt to login to the system using the employee's username and password.
        /// Returns NULL if the login failed.
        /// </summary>
        /// <param name="username">Employee's Username</param>
        /// <param name="password">Employee's Password</param>
        /// <returns>An object containing the data for the employee.</returns>
        public Employee Login(string username, string password)
        {
            var employee = _employees.Where(x => x.Username == username).FirstOrDefault();

            if (employee == null)
                return null;

            if (employee.Password != password)
                return null;

            return employee;
        }

        #endregion
    }
}
