﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Morgobot.Brain.Grammar;

namespace Tests
{
    [TestClass]
    public class WordTest
    {
        private Word _word;

        [TestInitialize]
        public void Init()
        {
            _word = new Word("первое");
        }

        [TestMethod]
        public void FindFirstVowelTest()
        {
            Assert.AreEqual(1, _word.FindFirstVowelIndex());
        }

        [TestMethod]
        public void IsVowelTest()
        {
            Assert.AreEqual(false, _word.IsVowel(2));
            Assert.AreEqual(true, _word.IsVowel(4));
        }

        [TestMethod]
        public void LengthTest()
        {
            Assert.AreEqual(6, _word.Length);
        }

        [TestMethod]
        public void SubstringTest()
        {
            Assert.AreEqual("ерв", _word.Substring(1,3));
        }
    }
}
