using nHomeIT.Tests.EmployeeSystem.Core;
using nHomeIT.WinForms.Metro;
using System;

namespace nHomeIT.Tests.EmployeeSystem.WinForms
{
    /// <summary>
    /// The form used to display Employee's data.
    /// </summary>
    public partial class DashboardForm : MetroFormBase
    {
        #region Fields

        private Employee _employee;

        #endregion

        #region Constructors

        /// <summary>
        /// Instantiates a new Dashboard Form displaying the provided employee's data.
        /// </summary>
        /// <param name="employee">Employee data to display</param>
        public DashboardForm(Employee employee)
        {
            _employee = employee;

            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles the event when the Form has been loaded and displayed.
        /// </summary>
        /// <param name="sender">The DashboardForm loaded</param>
        /// <param name="e">Event data (pretty much nothing of concern since it is a type of EventArgs)</param>
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblEmployeeID.Text = _employee.EmployeeID.ToString();
            lblFullName.Text = $"{_employee.FirstName} {_employee.LastName}";
            lblDateOfBirth.Text = _employee.DateOfBirth.ToShortDateString();
            lblAccessLevel.Text = _employee.AccessLevel.ToString();
        }

        #endregion

        private void lblEmployeeID_Click(object sender, EventArgs e)
        {

        }
    }
}
