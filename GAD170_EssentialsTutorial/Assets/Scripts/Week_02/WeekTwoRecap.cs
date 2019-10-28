using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoRecap : MonoBehaviour
{
    #region MyAwesomeVariables*COUGH*
    public int myInt; // An example of an Int
    /// <summary>
    /// The users name as a string
    /// </summary>
    public string myName;
    public float myHeight = 2.0f; // An example of a float
    /*
     * A string to hold the users last name;
     * 
     */
    public string myLastName = "Lyon";
    public bool myBool = false; // An example of a bool
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        // an example of a temp variable - only exists within these parenthesis.
        string myFavGame = myName + "Fave Game is " + "Rust";
        // Examples of debug.log and debug.logerror. Log.Error will pause editor if it is enabled in console.
        Debug.Log("This is logging out: " + myName + " " + myLastName);
        Debug.LogError("Hey there's an error!!!");
        Debug.Log(myFavGame);

         /*
         * An example of random.range. Returns random value between set parameters.
         */
        myInt = Random.Range(0, 20);
        myHeight = Random.Range(0f, 10f);
    }
}
