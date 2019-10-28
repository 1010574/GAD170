using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A script that demonstrates the correct setup and usage of variables inside of Unity
/// </summary>
public class VariableEtiquette : MonoBehaviour
{
    // The access type, the data type, variableName, default value I want to assign.
    public int myFirstInt = 1; // An int stores Whole Numbers
    private int m_mySecondInt = 4;
    public float myFirstFloat = 3.455f; // A Float stores decimal numbers, and requires the f symbol to denote it's a float when setting
    public double myFirstDouble = 0.11f; // Essentially a float but can go to 16 rather than 8 decimal places
    public bool myFirstBool = false; // A bool is used to store true or false statements
    public string myFirstString = "Kyle is awesomer"; // A string holds words, uses the quotation marks to denote that these words are a string
    public char myFirstChar = 'K'; // A Char holds a single character, nothing else. It has to use the single quotation marks to denote it's a char


    // Start is called before the first frame update
    void Start()
    {
        myFirstString = "Kyle remains awesomer"; // Sets myFirstString to "Kyle remains awesomer"
        myFirstInt = 5; // Sets myFirstInt to 5
        
        //Doing Something else
    }

}
