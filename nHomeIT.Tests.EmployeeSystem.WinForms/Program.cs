using nHomeIT.Tests.EmployeeSystem.Core;
using nHomeIT.Tests.EmployeeSystem.Core.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace nHomeIT.Tests.EmployeeSystem.WinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // These two lines are nothing to be concerned about at this level.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // The employees in the system.
            var sqlService = new SqlDataService();
            var employees = sqlService.getEmployees();

            // The service to retrieve employee data.
            var employeeService = new EmployeeService(employees);

            // The Login Form.
            var loginForm = new LoginForm(employeeService);

            // Starts the application.
            Application.Run(loginForm);
        }
    }
}
