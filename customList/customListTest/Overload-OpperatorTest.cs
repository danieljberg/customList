using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customList;

namespace customListTest
{
    [TestClass]
    public class Overload_OpperatorTest
    {
        [TestMethod]
        public void OverloadMinusOperator_RemoveIndex_Remove1FromListOne()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 2, 1, 6 };
            string expected = "3 5";
            CustomList<int> three;
            string actual;

            //Act            
            three = one - two;
            actual = three.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinusOperator_RemoveIndex_Remove3FromListOne()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 3, 4, 6 };
            string expected = "1 5";
            CustomList<int> three;
            string actual;

            //Act            
            three = one - two;
            actual = three.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinusOperator_RemoveIndex_Remove6FromListOne()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>() { 1, 3, 6 };
            CustomList<int> two = new CustomList<int>() { 2, 4, 6 };
            string expected = "1 3";
            CustomList<int> three;
            string actual;

            //Act            
            three = one - two;
            actual = three.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void OverloadMinusOperator_RemoveIndex_Remove3And5FromListOne()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 3, 5, 6 };
            string expected = "1";
            CustomList<int> three;
            string actual;

            //Act            
            three = one - two;
            actual = three.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadMinusOperator_RemoveNumbers_Remove3And5And6FromListOne()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>() { 1, 3, 5, 6 };
            CustomList<int> two = new CustomList<int>() { 3, 5, 6 };
            string expected = "1";
            CustomList<int> three;
            string actual;

            //Act            
            three = one - two;
            actual = three.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
