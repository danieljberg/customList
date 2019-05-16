using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customList;

namespace customListTest
{
    [TestClass]
    public class RemoveTest
    {
        [TestMethod]
        public void Remove_RemoveNumber_RemoveNumber15AtIndex2()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            int expected = 20;
            int actual;
            //Act
            myList.Remove(15);
            actual = myList.items[2];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveNumber_CountIsEqualTo3()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            int expected = 3;
            int actual;
            //Act
            myList.Remove(15);
            actual = myList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveNumber_RemoveNumber5AtIndex0()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            int expected = 10;
            int actual;
            //Act
            myList.Remove(5);
            actual = myList[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveNumber_RemoveNumber20AtIndex3()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            int expected = 3;
            int actual;
            //Act
            myList.Remove(20);
            actual = myList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveString_RemoveStringBearsAtIndex1()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("Packers");
            myList.Add("Bears");
            myList.Add("Lions");
            myList.Add("Vikings");
            string expected = "Bears";
            int actual;
            //Act
            myList.Remove("Bears");
            actual = myList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
