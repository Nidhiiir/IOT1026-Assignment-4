using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment.InterfaceCommand;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void PowerTest()
        {
            Robot testRobot = new() { IsPowered = true };
            Assert.AreEqual(testRobot.IsPowered, true);
            testRobot.IsPowered = false;
            Assert.AreEqual(testRobot.IsPowered, false);
        }

        [TestMethod]
        public void WestCommandTest()
        {
            Robot testRobot = new();
            Assert.AreEqual(testRobot.X, 0);
            testRobot.LoadCommand(new WestCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.X, 0);

            testRobot.IsPowered = true;
            testRobot.LoadCommand(new WestCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.X, -2);
            testRobot.Run();
            Assert.AreEqual(testRobot.X, -4);
        }

        [TestMethod]
        public void EastCommandTest()
        {
            Robot testRobot = new();
            Assert.AreEqual(testRobot.X, 0);
            testRobot.LoadCommand(new EastCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.X, 0);

            testRobot.IsPowered = true;
            testRobot.LoadCommand(new EastCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.X, 2);
            testRobot.Run();
            Assert.AreEqual(testRobot.X, 4);
        }

        [TestMethod]
        public void SouthCommandTest()
        {
            Robot testRobot = new();
            Assert.AreEqual(testRobot.Y, 0);
            testRobot.LoadCommand(new SouthCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.Y, 0);

            testRobot.IsPowered = true;
            testRobot.LoadCommand(new SouthCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.Y, -2);
            testRobot.Run();
            Assert.AreEqual(testRobot.Y, -4);
        }

        [TestMethod]
        public void NorthCommandTest()
        {
            Robot testRobot = new();
            Assert.AreEqual(testRobot.Y, 0);
            testRobot.LoadCommand(new NorthCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.Y, 0);

            testRobot.IsPowered = true;
            testRobot.LoadCommand(new NorthCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.Y, 2);
            testRobot.Run();
            Assert.AreEqual(testRobot.Y, 4);
        }

        [TestMethod]
        public void BachataCommandTest()
        {
            Robot testRobot = new();
            Assert.AreEqual(testRobot.X, 0);
            Assert.AreEqual(testRobot.Y, 0);
            testRobot.LoadCommand(new BachataCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.X, 0);
            Assert.AreEqual(testRobot.Y, 0);

            testRobot.IsPowered = true;
            testRobot.LoadCommand(new BachataCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.X, -6);
            Assert.AreEqual(testRobot.Y, 0);
        }

        [TestMethod]
        public void PropertiesTest()
        {
            Robot robot1 = new();
            Assert.AreEqual(robot1.NumCommands

