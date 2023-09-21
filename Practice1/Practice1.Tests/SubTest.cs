using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Tests
{
    [TestFixture]
    public class SubTest
    {
        [Test]
        public void TestSubjectName()
        {
            // Arrange
            Subject subject = new Subject();
            subject.SubName = "Biology";

            // Act
            string subjectName = subject.SubName;

            // Assert
            Assert.AreEqual("Biology", subjectName);
        }

        [Test]
        public void TestSubjectId()
        {
            // Arrange
            Subject subject = new Subject();
            subject.SubId = 2;

            // Act
            int subjectId = subject.SubId;

            // Assert
            Assert.AreEqual(2, subjectId);
        }
    }
}