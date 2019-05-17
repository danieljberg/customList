using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customList;

namespace customListTest
{
    [TestClass]
    public class ToStringTest
    {
        [TestMethod]
        public void ToString_ChangeToAString_ChangeMyListToAString()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            string expected = "5 10 15 20";
            string actual;
            //Act
            actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_ChangeToAString_ChangeToAString()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            myList.Add(25);
            myList.Add(30);
            myList.Add(35);
            string expected = "5 10 15 20 25 30 35";
            string actual;
            //Act
            actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
