using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using HangMan.Models;
using System;

namespace HangMan.Tests
{
    [TestClass]
    public class HangManTests
    {
        [TestMethod]
        public void HMGame_Constructs_Object()
        {
            HMGame test = new HMGame("Dad", 12);
            Assert.AreSame(test.Solution, "Dad");
        }
        [TestMethod]
        public void HMGame_HasUnsolvedSolution_String()
        {
            HMGame test = new HMGame("Dad", 12);
            test.Guess('D');
            Assert.AreEqual(test.Correct[0], 'D');
        }
        [TestMethod]
        public void HMGame_UnsolvedAddsUnderscores_String()
        {
            HMGame test = new HMGame("Dad", 12);
            test.Guess('D');
            Console.WriteLine(test.Unsolved);
            test.BuildUnsolved();
            Assert.AreEqual("D_D",test.Unsolved);
        }
    }

}