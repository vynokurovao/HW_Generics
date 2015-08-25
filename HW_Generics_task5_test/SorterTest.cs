using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_Generics_task5;
using System.Collections.Generic;

namespace HW_Generics_task5_test
{
    [TestClass]
    public class SorterTest
    {
        [TestMethod]
        public void Sort_WithListOfInts()
        {
            List<int> list = new List<int>() { 9, 2, 45, 5, 1};
            Sorter.Sort<List<int>, int>(list);
            List<int> expected = new List<int>() { 1, 2, 5, 9, 45};

            CollectionAssert.AreEqual(expected, list);
        }

        [TestMethod]
        public void Sort_WithListOfStrings()
        {
            List<string> stringList = new List<string>() {"Oksana", "Hello", "world", "hello", "this"};
            Sorter.Sort<List<string>, string>(stringList);
            List<string> expected = new List<string>() { "hello", "Hello", "Oksana", "this", "world" };

            CollectionAssert.AreEqual(expected, stringList);
        }
    }
}
