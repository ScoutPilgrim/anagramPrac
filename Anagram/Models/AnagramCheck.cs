using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class AnagramCheck
  {
    private string UserWord = "";
    private List<string> EnteredWords = new List<string>();
    private List<string> ConfirmedAnagrams = new List<string>();
    public AnagramCheck(string wordToCheck, List<string> listToCheck)
    {
      UserWord = wordToCheck;
      EnteredWords.AddRange(listToCheck);
    }
    public AnagramCheck()
    {

    }
    public string GetUserWord()
    {
      return UserWord;
    }
    public List<string> GetEnteredWords()
    {
      return EnteredWords;
    }
    public List<string> GetConfirmedAnagrams()
    {
      return ConfirmedAnagrams;
    }
    public bool IsAnagram(string mainWord, string checkWord)
    {
      char[] strOne = mainWord.ToCharArray();
      char[] strTwo = checkWord.ToCharArray();
      Array.Sort(strOne);
      Array.Sort(strTwo);
      string rebuildOne = new string(strOne);
      string rebuildTwo = new string(strTwo);
      return rebuildOne.Equals(rebuildTwo);
    }
    public List<string> FindAnagrams()
    {
      for(int i = 0; i < EnteredWords.Count;i++){
        if(IsAnagram(UserWord, EnteredWords[i])){
          ConfirmedAnagrams.Add(EnteredWords[i]);
        }
      }
      return ConfirmedAnagrams;
    }
  }
}
