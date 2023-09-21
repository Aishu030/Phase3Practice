using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Practice1;

namespace Practice1.Tests
{
    [TestFixture]
    public class TeachTest
    {
        [Test]
        public void Test_CreateTeacher()
        {
            // Arrange
            var teacher = new Teacher();
            teacher.TeacherId = 101;
            teacher.Name = "Mrs. Smith";

            // Act & Assert
            Assert.AreEqual(101, teacher.TeacherId);
            Assert.AreEqual("Mrs. Smith", teacher.Name);
        }
    }
}   



