using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MotorovaDD.Sprint4.Task3.V21.Lib;

namespace Tyuiu.MotorovaDD.Sprint4.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]

        public void Calc()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5]{ {8, 3, 3, 3, 5},
                                        {6, 7, 3, 3, 7},
                                        {4, 5, 4, 6, 6},
                                        {5, 5, 8, 8, 7},
                                        {4, 6, 6, 7, 7} };
            int res = ds.Calculate(mas);
            Assert.AreEqual(10290, res);
        }
    }
}
