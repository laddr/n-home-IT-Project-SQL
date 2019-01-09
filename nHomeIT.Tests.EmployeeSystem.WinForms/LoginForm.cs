using nHomeIT.Tests.EmployeeSystem.Core.Services;
using nHomeIT.WinForms.Metro;
using System;
using System.Windows.Forms;

namespace nHomeIT.Tests.EmployeeSystem.WinForms
{
    /// <summary>
    /// The form used by an Employee to login to the system.
    /// </summary>
    public partial class LoginForm : MetroFormBase
    {
        #region Fields

        private EmployeeService _employeeService;

        #endregion

        #region Contructors

        /// <summary>
        /// Instantiates a new Login Form using the Employee Service provided.
        /// </summary>
        /// <param name="employeeService">Employee Service to retrieve employee data.</param>
        public LoginForm(EmployeeService employeeService)
        {
            _employeeService = employeeService;

            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles the event when the user presses the Login button.
        /// Displays the employee's dashboard form.
        /// If the login failed, displays a message box to the user.
        /// If the employee is not active, displays a message box to the user.
        /// </summary>
        /// <param name="sender">The Login button</param>
        /// <param name="e">Event data (pretty much nothing of concern since it is a type of EventArgs)</param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var employee = _employeeService.Login(username, password);

            if (employee == null)
            {
                MessageBox.Show("No employee found for that username and password.");
                return;
            }

            if (!employee.IsActive)
            {
                MessageBox.Show("This employee is no longer active.");
                return;
            }

            var dashboard = new DashboardForm(employee);
            dashboard.Show();
        }

        #endregion
    }
}
