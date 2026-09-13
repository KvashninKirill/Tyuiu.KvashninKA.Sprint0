using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KvashninKA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KvashninKA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Кирилл";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Кирилл", res);
        }
    }
}
