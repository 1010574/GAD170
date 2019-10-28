using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuggingScript : MonoBehaviour
{

    public string myName = "Kyle"; // A string to hold my name
    public int myAge = 27; // An int to hold my age in years
    public bool myFirstBool = false; // A bool
    public int myAgeInMonths = 0; // An int to hold my age in months

    // Start is called before the first frame update
    void Start()
    {
        // Debug.log logs out a string message that we put inside of it.
        // we can add multiple strings and variables togethere to make one big string.
        // Debugging is useful for when we want to break down our code and check for bugs and where they occur.
        Debug.Log(myName);
        Debug.Log(myAge);
        Debug.Log(myFirstBool);
        Debug.Log(myAgeInMonths);
        Debug.Log(myName + " is this many years old: " + myAge);

        myAgeInMonths = myAge * 12;
        // This is an example of adding strings and variables together to make a string to log out.     
        Debug.Log("My age in months: " + myAgeInMonths);

        // This will pause the editor, allowing us to check certain scripts during runtime in our inspector.
        Debug.Break();

        // Logs out an error message if the console has pause on error the inspector will pause.
        Debug.LogError("There's been an error :'D");
        // Logs out a warning, will not pause the editor and will just show a warning message.
        Debug.LogWarning("This is just a warning");
    }

    // Update is called once per frame
    void Update()
    {
        myAgeInMonths = 23;
        // This log will be called every frame and is an example of how to check variables that are set later on in our code. 
        Debug.Log("My age in months: " + myAgeInMonths);
    }
}
