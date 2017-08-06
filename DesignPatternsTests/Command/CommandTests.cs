using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternImplementation.Command;

namespace DesignPatternsTests.Command
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        public void ShouldAddTextCommand()
        {
            var controller = new Controller();
            IAppCommand addTextCommand = new AddTextCommand();
            var addTextReference = controller.AddCommand(addTextCommand);
            var expected = "1234";
            controller.GetCommandAt(addTextReference).Execute(expected);
            Assert.AreEqual(expected, controller.GetBuiltString());
            Assert.AreEqual(expected, controller.GetCommandAt(addTextReference).sb.ToString());
        }
    }
}
