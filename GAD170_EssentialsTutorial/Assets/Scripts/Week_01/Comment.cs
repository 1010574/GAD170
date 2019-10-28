using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comment : MonoBehaviour
{

    //This is a single line comment

    /// <summary>
    /// myFirstBool is a bool that is my first.
    /// </summary>
    [Tooltip("A bool used for my first")]
    public bool myFirstBool = true;

    [Header("Player Name")]
    public string myFirstString = "SomeString";

    [Space(30)]
    public int myFirstInt = 1;

    /* Multiline Comment
     * this is a multiline comment!
     * you will notice when I press enter I get a new line!
     */

    #region Functions - Holds all the functions in my game

    /// <summary>
    /// this is a start function. It is called on the first frame of the game
    /// </summary>
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myFirstBool = false;
    }

    #endregion
}
