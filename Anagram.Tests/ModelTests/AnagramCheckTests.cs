using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System;
using System.Collections.Generic;

namespace Anagram.TestTools{
  [TestClass]
  public class AnagramCheckTest
  {
    [TestMethod]
    public void Constructor_Test()
    {
      List<string> testList = new List<string>{"etts"};
      string testString = "test";
      AnagramCheck testAnaChk = new AnagramCheck(testString, testList);
      Assert.AreEqual(testString, testAnaChk.GetUserWord());
      CollectionAssert.AreEqual(testList, testAnaChk.GetEnteredWords());
    }
    [TestMethod]
    public void IsAnagram_Test()
    {
      string testString = "test";
      string passString = "etts";
      string failString = "tttt";
      AnagramCheck testAnaChk = new AnagramCheck();
      Assert.AreEqual(true, testAnaChk.IsAnagram(testString, passString));
      Assert.AreEqual(false, testAnaChk.IsAnagram(testString, failString));
    }
    [TestMethod]
    public void FindAnagrams_TestAll()
    {
      List<string> testList = new List<string>{"etts", "sett"};
      List<string> answerList =  new List<string>{"etts","sett"};
      string testString = "test";
      AnagramCheck testAnaChk = new AnagramCheck(testString, testList);
      CollectionAssert.AreEqual(answerList, testAnaChk.FindAnagrams());
    }
    [TestMethod]
    public void FindAnagrams_TestSome()
    {
      List<string> testList = new List<string>{"etts", "sett", "florbo", "tset", "notthis"};
      List<string> answerList =  new List<string>{"etts","sett","tset"};
      string testString = "test";
      AnagramCheck testAnaChk = new AnagramCheck(testString, testList);
      CollectionAssert.AreEqual(answerList, testAnaChk.FindAnagrams());
    }
    [TestMethod]
    public void FindAnagrams_TestNone()
    {
      List<string> testList = new List<string>{"florbo", "notthis", "anagram", "notacatch"};
      List<string> answerList =  new List<string>();
      string testString = "test";
      AnagramCheck testAnaChk = new AnagramCheck(testString, testList);
      CollectionAssert.AreEqual(answerList, testAnaChk.FindAnagrams());
    }
  }
}
