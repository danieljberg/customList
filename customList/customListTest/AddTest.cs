using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customList;

namespace customListTest
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void Add_AddingToList_Add5ToFirstIndex()
        {
            
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;
            int actual = myList[0]; 
            //Act
            myList.Add(expected);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_CheckFirstIndex_FirstIndex5()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value1 = 10;
            int expected = 5;
            int actual = myList[0];
            //Act
            myList.Add(value);
            myList.Add(value1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_CheckSecondIndex_SecondIndex10()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value1 = 10;
            int expected = 10;
            int actual = myList[1];
            //Act
            myList.Add(value);
            myList.Add(value1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Count_ListCountEqualTo2()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value1 = 10;
            int expected = 2;
            int actual = myList.Count;
            //Act
            myList.Add(value);
            myList.Add(value1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToList_Add5Numbers()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value1 = 10;
            int value2 = 15;
            int value3 = 20;
            int value4 = 25;
            int expected = value4;
            int actual = myList[4];
            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            //Assert
            Assert.AreEqual(value4, myList[4]);
        }

        [TestMethod]
        public void Add_AddString_StringPackersAddedToList()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string word = "Packers";
            string word1 = "Bears";
            string word2 = "Lions";
            string word3 = "Vikings";
            string expected = word;
            string actual = myList[0];
            //Act
            myList.Add(word);
            myList.Add(word1);
            myList.Add(word2);
            myList.Add(word3);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Contain_Index3ShouldBeNull()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string word = "Packers";
            string expected = null;
            string actual;
            //Act
            myList.Add(word);
            actual = Assert.IsNull(myList[3]);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        //public void Remove_RemoveNumber_RemoveNumber15AtIndex2()
        //{
        //    //Arrange


        //    //Act


        //    //Assert
        //}
    }
}
