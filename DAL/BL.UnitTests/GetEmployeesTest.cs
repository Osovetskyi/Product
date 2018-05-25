using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BL.UnitTests
{
    [TestClass]
    public class GetEmployeesTest
    {
        [TestMethod]
        public void ReturnEmployeesTest_output_NotEmptyCollection()
        {
            // Arrange
            var employees = new GetEmployees();
            var repo = new Mock<EmployeeRepository>();
            repo.Setup(arg => arg.GetList()).Returns(new List<Employee>());
            employees.employeeRepository = repo.Object;

            // Act
            var resultCollection = employees.ReturnEmployees();

            // Assert
            Assert.IsNotNull(resultCollection);
        }
    }
}
