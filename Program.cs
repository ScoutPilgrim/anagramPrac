using System;
using System.Collections.Generic;
using Anagram.Models;

class Program
{
  public static void PrintAnswer(string myString, List<string> myStringList, bool ifFound)
  {
    if(ifFound){
      Console.WriteLine("For your word " +myString+", these Anagrams were found:");
      for(int i = 0; i < myStringList.Count; i++){
        int iterNum = i + 1;
        Console.WriteLine("Anagram" +iterNum+ ": " + myStringList[i]);
      }
    }else{
      Console.WriteLine("Im sorry to say that no Anagrams were found...");
    }
  }
  public static void Main()
  {
    List<string> mainList = new List<string>();
    Console.WriteLine("Enter the anagramable word.");
    string mainWord = Console.ReadLine();
    Console.WriteLine("Your entered word is " + mainWord + "!");
    Console.WriteLine("Please enter a list of words to check seperated by commas.");
    string toBecomeList = Console.ReadLine();
    string[] middleManArray = toBecomeList.Split(',');
    for(int i = 0; i < middleManArray.Length; i++){
      mainList.Add(middleManArray[i]);
    }
    AnagramCheck anaObj = new AnagramCheck(mainWord, mainList);
    List<string> answerList = anaObj.FindAnagrams();
    bool anaFound = answerList.Count > 0 ? true : false;
    PrintAnswer(mainWord, answerList, anaFound);
  }
}
