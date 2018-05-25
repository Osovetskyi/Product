using System;
using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BL.UnitTests
{
    [TestClass]
    public class AddEmployeeTest
    {
        [TestMethod]
        public void AddEmpTest_input_name_qual_rahunok_number_output_true()
        {
            // Arrange
            string name = "Шевченко Тарас Григорович";
            string qual = "Журналіст";
            string rahunok = "34567";
            string number = "32109";
            var employees = new AddEmployee();
            var repo = new Mock<EmployeeRepository>();
            repo.Setup(arg => arg.Create(It.IsAny<Employee>()));
            repo.Setup(arg => arg.Save());
            employees.employee = repo.Object;

             // Act
             var result = employees.AddEmp(name, qual,rahunok, number);

            // Assert
            Assert.IsTrue(result);
            repo.Verify(arg => arg.Create(It.IsAny<Employee>()), Times.Once());
            repo.Verify(arg => arg.Save(), Times.Once());
        }
    }
}
