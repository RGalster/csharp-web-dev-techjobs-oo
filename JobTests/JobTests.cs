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
            Job testJob1 = new Job("job1", new Employer("Bossman"), new Location("place1"), new PositionType("Test Tester"), new CoreCompetency("supension of disbelief"));

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
            Assert.AreEqual(testJob3.JobCoreCompetency.value, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJobX = new Job("Worker", new Employer("Company"), new Location("Place"), new PositionType("Industry"), new CoreCompetency("Quality"));

            Job testJobY = new Job("Worker", new Employer("Company"), new Location("Place"), new PositionType("Industry"), new CoreCompetency("Quality"));

            Assert.IsFalse(testJobX.Equals(testJobY));
        }
    }
}

//Job testJob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));