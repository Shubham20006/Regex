using RegexAssignment;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        UserRegestration UR = new UserRegestration();
        [TestMethod]
        public void TestForHappy_Firstname()
        {
            bool expected = true;

            bool actual = UR.firstName("Shu");
            
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForHappy_lasttname()
        {
            bool expected = true;

            bool actual = UR.LastName("Cha");

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForHappy_email()
        {
            bool expected = true;

            bool actual = UR.email("shubham@gmail.com");

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForHappy_MobNum()
        {
            bool expected = true;

            bool actual = UR.mobile("91 9546531534");

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForHappy_Pass()
        {
            bool expected = true;

            bool actual = UR.PassWord("Shubham@1545");

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForSad_Firstname()
        {
            bool expected = false;

            bool actual = UR.firstName("Shubh");

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForsad_lasttname()
        {
            bool expected = false;

            bool actual = UR.LastName("Chaudhari");

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForSad_email()
        {
            bool expected = false;

            bool actual = UR.email("Shubhamgmail.com");

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForSad_MobNum()
        {
            bool expected = false;

            bool actual = UR.mobile("9546531534");

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForSad_Pass()
        {
            bool expected = false;

            bool actual = UR.PassWord("Shubham");

            Assert.AreEqual(expected, actual);
        }
    }
}