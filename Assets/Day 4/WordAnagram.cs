using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordAnagram : MonoBehaviour
{
    public string wordOne,wordTwo;
    void Start()
    {
        print(AnagramOrNot(wordOne, wordTwo));

    }



    /*This method takes two arguements of string datatype and returns a bool datatype
    * This method checks if the word is ANAGRAM or Not;
    * if it is anagram it will return True else it will return false;
    */
    bool AnagramOrNot(string wordone, string wordtwo)
    {
        char[] characterWord1 = SortingWord(wordone);
        char[] characterWord2 = SortingWord(wordtwo);

        string word1 = CharacterArraytoString(characterWord1);
        string word2 = CharacterArraytoString(characterWord2);
        bool equalOrNot = false;

        if (word1 == word2)
            return equalOrNot = true;
        else
            return equalOrNot;
    }



    /*This method takes two arguements of string datatype and returns a bool datatype
     * This method checks if the strings are equal or not;
     */

    ////bool StringEqualChecker(string wordone, string wordtwo)
    ////{
    ////    char[] characterWord1 = SortingWord(wordone);
    ////    char[] characterWord2 = SortingWord(wordtwo);

    ////    string word1 = CharacterArraytoString(characterWord1);
    ////    string word2 = CharacterArraytoString(characterWord2); 

    ////    bool equalOrNot = false;

    ////    if (word1 == word2)
    ////        return equalOrNot = true;
    ////    else
    ////        return equalOrNot;

    ////}



    /*This method takes one arguement of Char Array datatype and returns a string datatype
    * This method converts the char array to string;
    */

    string CharacterArraytoString(char[] characterword)
    {
        string Word="";
        for (int i = 0; i < characterword.Length; i++)
        {

            Word += characterword[i];
        }
        return Word;
    }

    /*This method takes one arguements of string datatype and returns a char array datatype
    * This method sorts the string word to char array;
    */
    char[] SortingWord(string word)
    {
        char[] sortedWord = WordsToCharacter(word);
        char temp;
        for(int x = 0; x<sortedWord.Length;x++)
        {
            for (int y = 0; y < sortedWord.Length - 1; y++)
            {
                if (sortedWord[y] > sortedWord[y + 1])
                {
                    temp = sortedWord[y];
                    sortedWord[y] = sortedWord[y + 1];
                    sortedWord[y + 1] = temp;
                }
            }
        }
        return sortedWord;
    }

    /*This method takes one arguement of string datatype and returns a char array datatype
    * This method  converts the string to char array; 
    */
    char[] WordsToCharacter(string word)
    {
    char[] wordCharacters = new char[word.Length];

        for(int x=0;x<word.Length;x++)
        {
            wordCharacters[x] = word[x];
        }
        return wordCharacters;
     }
}
