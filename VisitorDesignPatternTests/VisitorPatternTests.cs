using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using NUnit.Framework;
using VisitorDesignPattern;
using System;
using System.IO;

namespace VisitorDesignPatternTests
{
    [TestFixture]
    public class VisitorPatternTests
    {
        [Test]
        public void DoctorVisitsKid_ShouldOutputCorrectMessage()
        {
            var doctor = new Doctor("James");
            var kid = new Kid("Tom");
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                kid.Accept(doctor);

                var expected = string.Format("Doctor: James did the health checkup of the child: Tom{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void SalesmanVisitsKid_ShouldOutputCorrectMessage()
        {
            var salesman = new Salesman("John");
            var kid = new Kid("Alice");
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                kid.Accept(salesman);

                var expected = string.Format("Salesman: John give a school bag to the child: Alice{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void SchoolPerformOperationWithDoctor_ShouldOutputCorrectMessages()
        {
            var school = new School();
            var doctor = new Doctor("James");
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                school.PerformOperation(doctor);

                var expected = string.Format(
                    "Doctor: James did the health checkup of the child: Ram{0}" +
                    "Doctor: James did the health checkup of the child: Sara{0}" +
                    "Doctor: James did the health checkup of the child: Pam{0}",
                    Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void SchoolPerformOperationWithSalesman_ShouldOutputCorrectMessages()
        {
            var school = new School();
            var salesman = new Salesman("John");
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                school.PerformOperation(salesman);

                var expected = string.Format(
                    "Salesman: John give a school bag to the child: Ram{0}" +
                    "Salesman: John give a school bag to the child: Sara{0}" +
                    "Salesman: John give a school bag to the child: Pam{0}",
                    Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void VisitorVisitsKid_ShouldNotChangeKidState()
        {
            var kid = new Kid("Alice");
            var originalName = kid.KidName;
            var doctor = new Doctor("James");

            kid.Accept(doctor); // Simulate doctor visit

            Assert.AreEqual(originalName, kid.KidName); // Kid's name should remain unchanged
        }
    }
}
