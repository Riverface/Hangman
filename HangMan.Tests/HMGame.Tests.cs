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
            Assert.AreEqual(test.Solution, "dad");
        }
        [TestMethod]
        public void HMGame_HasUnsolvedSolution_String()
        {
            HMGame test = new HMGame("Dad", 12);
            test.Guess('D');
            Assert.AreEqual(test.Correct[0], 'd');
        }
        [TestMethod]
        public void HMGame_UnsolvedAddsUnderscores_String()
        {
            HMGame test = new HMGame("Dad", 12);
            test.Guess('D');
            // test.Unsolved should equal D_D
            // Correct should equal D
            test.BuildUnsolved();
            Assert.AreEqual("d_d", test.Unsolved);
        }
        [TestMethod]
        public void HMGame_RemembersAllGuesses_String()
        {
            HMGame test = new HMGame("Dad", 12);
            test.Guess('d');
            test.Guess('p');
            test.Guess('a');
            // test.Unsolved should equal D_D
            // Correct should equal D
            Assert.AreEqual("da", test.Correct);
            Assert.AreEqual('p', test.Wrong);
        }
    }

}