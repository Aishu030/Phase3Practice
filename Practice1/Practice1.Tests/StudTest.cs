using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice1.Tests
{
    [TestFixture]
    public class StudTest
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.SName = "Allen bill";

            // Act
            string studentName = student.SName;

            // Assert
            Assert.AreEqual("Allen bill", studentName);
        }

        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "12 park Street";

            // Act
            string studentAddress = student.Address;

            // Assert
            Assert.AreEqual("12 park Street", studentAddress);
        }
    }
}

    
