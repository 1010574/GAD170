using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigLatinConverter : MonoBehaviour
{
    public string wordToConvert; // The word we are going to convert.
    
    // Start is called before the first frame update
    void Start()
    {
        ConvertPhrase(wordToConvert);
    }

    /// <summary>
    /// Takes in words and outputs the converted pig latin phrase.
    /// </summary>
    /// <param name="wordsToConvert"></param>
    public void ConvertPhrase(string wordsToConvert)
    {
        // Splits the phrase into individual words using space as the splitting point.
        string[] words = wordsToConvert.Split(' ');
        // A string to store the converted words as it's processed.
        string returnedConvertedPhrase = string.Empty;

        // go through each of the words split up and convert them, then store them back in the converted phrase string.
        for(int i=0; i<words.Length; i++)
        {
            returnedConvertedPhrase += ConvertSingularWords(words[i]) + " ";
        }

        // Prints out the converted phrase.
        Debug.Log(returnedConvertedPhrase);
    }

    /// <summary>
    /// Takes in a word and converts that word into pig latin.
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    public string ConvertSingularWords(string word)
    {
        // Checks to see if the first character of the word is a vowel
        if (IsVowel(word[0]))
        {
            // If it is, just return the word + "yay" at the end.
            return word + "yay";
        }
        else
        {
            // Some strings to hold our split word.
            string wordOne = string.Empty;
            string wordTwo = string.Empty;

            // For loop going through each letter of out word.
            for(int i=0; i<word.Length; i++)
            {
                // If letter is a vowel, start another for loop
                // and go through the remainder letters and add it to word two.
                if (IsVowel(word[i]))
                {
                    for(int j = i; j<word.Length; j++)
                    {
                        wordTwo += word[j];
                    }
                    break;
                }
                // The letter musn't be a vowel yet, keep adding the letters to wordOne.
                wordOne += word[i];
            }
            // Returns the two words as one, with the letter switched and ay at the end. 
            return wordTwo + wordOne + "ay";
        }
    }

    /// <summary>
    /// Function that returns true if first letter is a vowel.
    /// </summary>
    /// <param name="CharacterToCheck"></param>
    /// <returns></returns>
    private bool IsVowel(char CharacterToCheck)
    {
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        return CompareCharacter(CharacterToCheck, vowels);
    }

    /// <summary>
    /// Function checks to see if the character is actually a vowel.
    /// </summary>
    /// <param name="CharacterToCheck"></param>
    /// <param name="ToCheckAgainst"></param>
    /// <returns></returns>
    private bool CompareCharacter(char CharacterToCheck, char[] ToCheckAgainst)
    {
        // Goes through each character in the array to check if it's a vowel.
        for(int i=0; i<ToCheckAgainst.Length; i++)
        {
            // If it is a vowel, return true.
            if(CharacterToCheck == ToCheckAgainst[i])
            {
                return true;
            }
        }
        // If it's not a vowel, return false. 
        return false;
    }

}
