using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customList;


namespace customListTest
{
    [TestClass]
    public class Overload_OperatorTest
    {
        [TestMethod]
        public void OverloadPlusOperator_AddTwoCustomLists_twoListsAddedTogether()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 2, 4, 6 };
            string expected = "1 3 5 2 4 6";
            CustomList<int> three;
            string actual;

            //Act            
            three = one + two;
            actual = three.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadPlusOperator_AddLongerLists_twoListsAddedTogether()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>() { 1, 3, 5, 7, 9, 11 };
            CustomList<int> two = new CustomList<int>() { 2, 4, 6, 8, 10, 12 };
            string expected = "1 3 5 7 9 11 2 4 6 8 10 12";
            CustomList<int> three;
            string actual;

            //Act            
            three = one + two;
            actual = three.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadPlusOperator_count_countShouldBe6()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 2, 4, 6 };
            int expected = 6;
            CustomList<int> three;
            int actual;

            //Act            
            three = one + two;
            actual = three.count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadPlusOperator_count_countShouldBe12()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>() { 1, 3, 5, 7, 9, 11 };
            CustomList<int> two = new CustomList<int>() { 2, 4, 6, 8, 10, 12 };
            int expected = 12;
            CustomList<int> three;
            int actual;

            //Act            
            three = one + two;
            actual = three.count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
