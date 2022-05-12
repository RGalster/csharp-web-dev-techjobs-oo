using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace JobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job("job1", new Employer("Bossman"), new Location("place1"), new PositionType("Test Tester"), new CoreCompetency("suspension of disbelief"));

            Job testJob2 = new Job("job2", new Employer("Bosslady"), new Location("paradise"), new PositionType("Test Tester Tester"), new CoreCompetency("goes with the flows"));

            Assert.AreEqual((testJob1.Id + 1), testJob2.Id, .001);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job testJob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(testJob3.Name, "Product tester");
            Assert.AreEqual(testJob3.EmployerName.Value, "ACME");
            Assert.AreEqual(testJob3.EmployerLocation.Value, "Desert");
            Assert.AreEqual(testJob3.JobType.Value, "Quality control");
            Assert.AreEqual(testJob3.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJobX = new Job("Worker", new Employer("Company"), new Location("Place"), new PositionType("Industry"), new CoreCompetency("Quality"));

            Job testJobY = new Job("Worker", new Employer("Company"), new Location("Place"), new PositionType("Industry"), new CoreCompetency("Quality"));

            Assert.IsFalse(testJobX.Equals(testJobY));
        }

        Job testJobTDD1;

        [TestInitialize]
        public void CreateTestJob()
        {
            testJobTDD1 = new Job("Underwater Basket Weaver", new Employer("Joe's"), new Location("the Pool"), new PositionType(null), new CoreCompetency("can hold breath"));
        }

        [TestMethod]
        public void TestForBlankLines()
        {
            //Job testJobTDD1 = new Job("Underwater Basket Weaver", new Employer("Joe's"), new Location("the Pool"), new PositionType("entertainment"), new CoreCompetency("can hold breath"));

            //Assert.AreEqual(testJobTDD1.ToString(), ("_______the Pool_______"));
            Assert.AreEqual(testJobTDD1.ToString(), "\nID: 2\nName: Underwater Basket Weaver\nEmployer: Joe's\nLocation: the Pool\nPosition Type: Data not available\nCore Competency: can hold breath\n");
        }

        [TestMethod]
        public void TestLabels()
        {
            //Assert.AreEqual(testJobTDD1.ToString(), "ID: _______8_______");
            Assert.AreEqual(testJobTDD1.ToString(), "\nID: 8\nName: Underwater Basket Weaver\nEmployer: Joe's\nLocation: the Pool\nPosition Type: Data not available\nCore Competency: can hold breath\n");
        }

        [TestMethod]
        public void TestEmptyField()
        {
            //Assert.AreEqual(testJobTDD1.ToString(), "Data not available");
            Assert.AreEqual(testJobTDD1.ToString(), "\nID: 1\nName: Underwater Basket Weaver\nEmployer: Joe's\nLocation: the Pool\nPosition Type: Data not available\nCore Competency: can hold breath\n");
        }

        [TestMethod]
        public void TestTooManyEmptyFields()
        {
            Job emptyTestJob = new Job("", new Employer(null), new Location(null), new PositionType(null), new CoreCompetency(null));
            Assert.AreEqual(emptyTestJob.ToString(), "OOPS! This job does not seem to exist.");
        }
    }
}

//Job testJob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));