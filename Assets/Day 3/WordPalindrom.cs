using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordPalindrom : MonoBehaviour
{
    public string word = "civic";
    
    // Start is called before the first frame update
    void Start()
    {
        print("The Word is Palindrome "+PalindromeOrNot(word));
        print("Reverse Word" + ReverseWord(word));
        PalindromesFromWord(word);
    }

    /*This method takes a parameter of String;
     *Returns value of Boolean; 
     *This method Checks the word if it is Palindrome or Not;
     * 
     */
    bool PalindromeOrNot(string word)
    {
        bool palindromOrNot;
        int totalNumberOfWords = word.Length;
        string reverseWord = ReverseWord(word);

        if (totalNumberOfWords > 1)
        {
            if (word == reverseWord)
                return palindromOrNot = true;
            else
                return palindromOrNot = false;
        }
        else
            return palindromOrNot = false; 
    }

    /*This method takes a paramete of String DataType;
     * does not return any value;
     * it prints all the Palindromes in passed String;
     */
    void PalindromesFromWord(string word) {
        int totalNumberOfWords = word.Length;
        string subword;

        for(int x = 1; x < totalNumberOfWords; x++)
        {
            for(int y = 0; y < totalNumberOfWords-x;y++)
            {
                subword = word.Substring(y,x);
                if (PalindromeOrNot(subword))
                    print("Palindrome subString is " + subword);
            }
        }
                                                                                                //if(word[0] == word[1])
                                                                                               //    print(word[0] + word[1]);
                                                                                                 //if (word[0] == word[2])
                                                                                            //    print(word[0] + word[0+1] + word[2]);
                                                                                            //if (word[1] == word[3])
                                                                                                            //{
                                                                                              //    subword += word[1];
                                                                                                 //    subword += word[2];
                                                                                         //    subword += word[3];
                                                                                          //    print(subword);
                                                                                         //}
    }

    /* This method takes a parameter or argument of String datatype;
     * Return value in String dataType;
     * this method specifically reverses the entered string;
     */
    string ReverseWord(string word)
    {
        string reverseword="";
        int totalnumberofWord = word.Length;

        for(int i = totalnumberofWord-1; i>=0;i--)
        {
            reverseword += word[i];
        }

        return reverseword;
    }
}
        

  

