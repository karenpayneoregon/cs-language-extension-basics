using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using ExtensionsLibrary;
using ExtensionsTestProject.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionsTestProject
{
    [TestClass]
    public class UnitTest1 : BaseClass
    {
        /// <summary>
        /// Given a string array get only int values,
        /// discard non-integer values
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.IntArrayTest)]
        public void GetIntValuesFromStringArray()
        {

            int[] expected = { 2, 6 };
            var t = TestContextInstance.TestName;

            string[] stringArray = { "2", null, "6", "8A" };

            var result = stringArray.ToIntegerArray();


            Assert.IsTrue(result.SequenceEqual(expected), 
                $"{TestContextInstance.TestName} SequenceEqual failed");

        }
        /// <summary>
        /// Given a string array get indices
        /// of non-integer values
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.IntArrayTest)]
        public void GetNonIntValuesFromStringArray()
        {

            int[] expected = { 1, 3 };
            var t = TestContextInstance.TestName;

            string[] stringArray = { "2", "4B", "6", "8A" };

            var result = stringArray.GetNonIntegerIndexes();

            Assert.IsTrue(result.SequenceEqual(expected), 
                $"{TestContextInstance.TestName} SequenceEqual failed");

        }
        /// <summary>
        /// Given a start and end date determine if
        /// a date falls between start and end date
        ///
        /// Given a start and end int determine if
        /// a int falls between start and end int
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.GenericTest)]
        public void GenericBetweenDates()
        {
            var startDate = new DateTime(2018, 12, 
                2, 1, 12, 0);

            var endDate = new DateTime(2018, 12, 
                15, 1, 12, 0);

            var theDate = new DateTime(2018, 12, 
                13, 1, 12, 0);

            Assert.IsTrue(theDate.Between(startDate,endDate));

        }
        /// <summary>
        /// Given a start and end int determine if
        /// a int falls between start and end int
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.GenericTest)]
        public void GenericBetweenInt()
        {

            var startInt = 3;
            var endInt = 7;
            Assert.IsTrue(5.Between(startInt, endInt));

            Assert.IsTrue(7.Between(startInt, endInt));
            Assert.IsFalse(7.BetweenExclusive(startInt, endInt));

        }
        /// <summary>
        /// Given a TimeSpan format with AM/PM
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.TimeSpanTest)]
        public void FormattedTimeSpan()
        {
            var expected1 = "01:15 PM";

            var timeSpan = new TimeSpan(13, 15, 0);
            var formattedTimeSpan = timeSpan.Formatted();

            Assert.IsTrue(formattedTimeSpan == expected1, 
                $"{TestContextInstance.TestName} expected {expected1}");

        }
        /// <summary>
        /// Given a Pascal cased string split on upper case characters
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.StringTest)]
        public void StringSplitCamelCase()
        {

            string valueToSplit = "CompanyName";
            string expected =  "Company Name";

            Assert.IsTrue(valueToSplit.SplitCamelCase() == expected, 
                $"{TestContextInstance.TestName} expected {expected}");

        }

        /// <summary>
        /// Given a Pascal cased string split on upper case characters
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.TimeSpanTest)]
        public void TimeSpanToDate()
        {
            var expected = new DateTime(
                DateTime.Now.Year,
                DateTime.Now.Month, 
                DateTime.Now.Day,1,15,0);

            var timeSpan = new TimeSpan(13, 15, 0);

            var result = timeSpan.ToDateTime();

            Assert.IsTrue(result == expected, 
                $"{TestContextInstance.TestName} Failed creating Date from TimeSpan");

        }
        /// <summary>
        /// Add only items not in values array
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.GenericTest)]
        public void AddUniqueIntegers()
        {
            var values = new List<int>() {1,2,3};
            var values1 = new List<int>() {10,2,3};

            foreach (var item in values1)
            {
                values.AddItem(item);
            }
            
            Assert.IsTrue(values.Count == 4);
        }
        /// <summary>
        /// Add only items not in values array
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.GenericTest)]
        public void AddUniqueStrings() 
        {
            var values = new List<string>()
                { "Monday", "Tuesday","Wednesday","Thursday","Friday"};

            var values1 = new List<string>()
                { "Monday", "Tuesday","Wednesday","Saturday","Sunday"};

            foreach (var item in values1)
            {
                values.AddItem(item);
            }

            Assert.IsTrue(values.Count == 7);

        }
        /// <summary>
        /// Provides a simple way to reduce a if or
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.GenericTest)]
        public void InIntExample()
        {
            int reallyLongIntegerVariableName = 9;

            Assert.IsTrue(reallyLongIntegerVariableName.In(1, 6, 9, 11));
            Assert.IsFalse(reallyLongIntegerVariableName.In(1, 6, 19, 11));

        }
        /// <summary>
        /// Provides a simple way to reduce a if or
        /// </summary>
        [TestMethod]
        [TestTraits(Trait.GenericTest)]
        public void InStringExample()
        {
            string reallyLongStringVariableName = "Apples";
            Assert.IsTrue(reallyLongStringVariableName.In("Oranges","Apples","Grapes"));
        }

    }
}
