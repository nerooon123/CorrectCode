using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CorrectCodeLibrary;

namespace CorrectCodeLibraryTests
{
    [TestClass]
    public class CorrectCodeClassTests
    {
        [TestMethod]
        public void CorrectCodeLibrary_CorrectCodeClass_ReturnFalseOne()
        {
            // arrange
            string ex = "";
            // act
            bool cl = CorrectCodeClass.IsCorrectCode(ex);
            // assert
            Assert.IsFalse(cl);
        }

        [TestMethod]
        public void CorrectCodeLibrary_CorrectCodeClass_ReturnFalseTwo()
        {
            // arrange
            string ex = "123";
            // act
            bool cl = CorrectCodeClass.IsCorrectCode(ex);
            // assert
            Assert.IsFalse(cl);
        }

        [TestMethod]
        public void CorrectCodeLibrary_CorrectCodeClass_ReturnFalseThree()
        {
            // arrange
            string ex = "123123123123123";
            // act
            bool cl = CorrectCodeClass.IsCorrectCode(ex);
            // assert
            Assert.IsFalse(cl);
        }

        [TestMethod]
        public void CorrectCodeLibrary_CorrectCodeClass_ReturnFalseFour()
        {
            // arrange
            string ex = "strokasymb";
            // act
            bool cl = CorrectCodeClass.IsCorrectCode(ex);
            // assert
            Assert.IsFalse(cl);
        }

        [TestMethod]
        public void CorrectCodeLibrary_CorrectCodeClass_ReturnTrueOne()
        {
            // arrange
            string ex = "1234123400";
            // act
            bool cl = CorrectCodeClass.IsCorrectCode(ex);
            // assert
            Assert.IsTrue(cl);
        }

        [TestMethod]
        public void CorrectCodeLibrary_CorrectCodeClass_ReturnTrueTwo()
        {
            // arrange
            string ex = "1234123401";
            // act
            bool cl = CorrectCodeClass.IsCorrectCode(ex);
            // assert
            Assert.IsTrue(cl);
        }

        [TestMethod]
        public void CorrectCodeLibrary_CorrectCodeClass_ReturnFalseFive()
        {
            // arrange
            string ex = "1234123404";
            // act
            bool cl = CorrectCodeClass.IsCorrectCode(ex);
            // assert
            Assert.IsFalse(cl);
        }

        [TestMethod]
        public void CorrectCodeLibrary_CorrectCodeClass_ReturnеTrueThree()
        {
            // arrange
            string ex = "3000030001";
            // act
            bool cl = CorrectCodeClass.IsCorrectCode(ex);
            // assert
            Assert.IsFalse(cl);
        }

        [TestMethod]
        public void CorrectCodeLibrary_CorrectCodeClass_ReturnеTrueFour()
        {
            // arrange
            string ex = "3000130009";
            // act
            bool cl = CorrectCodeClass.IsCorrectCode(ex);
            // assert
            Assert.IsTrue(cl);
        }
    }
}
