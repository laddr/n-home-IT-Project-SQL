using System;

namespace nHomeIT.Tests.EmployeeSystem.Core
{
    /// <summary>
    /// Represents an Employee in the system.
    /// </summary>
    public class Employee
    {
        #region Properties

        public int EmployeeID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsActive { get; set; }
        public AccessLevel AccessLevel { get; set; }

        #endregion
    }

    /// <summary>
    /// Represents all the different system Access Levels.
    /// </summary>
    public enum AccessLevel
    {
        Administrator = 1,
        Management = 2,
        Basic = 3
    }
}
