# Anagram.Solution
## Ian Christner


### Description:
A simple .NET console application where a user is prompted for word that they want to find anagrams of. The user then inputs words that they want to check as an anagram possibility. These words should be separated by commas. The program then returns all found Anagrams to the user through the console.


What it does:
* User enters a word that they want to compare other possible anagrams to which is stored in a string
* Player then enters however many words they wish to compare, which are then stored into a List Obj.
* The initial string and the List are then used to create an AnagramCheck Object
* The FindAnagrams() method is then called on the new Object, which returns a List Obj containing all of the found anagrams.
* The PrintAnswer() helper function is then called to print out the found Anagrams to the user through the Console

Included Specifications:
* The list of words to compare is built by first making a string array by using .Split(',') on the user input.
* To find if something is an anagram, the program parses through the List of user entered words. For each Element of the List (which are strings), the Primary User Word and the List element are both sorted into char arrays. After being sorted, the char arrays are then built back into strings, where they are compared for equality.
* If the sorted strings are deemed equal, the List element is then added into a separate list that is meant to hold found anagrams.
* After the List has been completely iterated through, the program then prints out the words that were found to be anagrams to the console for by Iterating through the List of found anagrams.

#### The MIT License

#### Copyright (c) 2019 Ian Christner

Permission is hereby granted, free of charge,
to any person obtaining a copy of this software and
associated documentation files (the "Software"), to
deal in the Software without restriction, including
without limitation the rights to use, copy, modify,
merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom
the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice
shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR
ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
