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
            int actual = myList[2];
            //Act
            myList.Remove(15);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveNumber_CountIsEqualTo3()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value1 = 10;
            int value2 = 15;
            int value3 = 20;
            int expected = 3;
            int actual;
            //Act
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveNumber_RemoveNumber15AtIndex2()
        {
            //Arrange


            //Act


            //Assert
        }
    }
}
