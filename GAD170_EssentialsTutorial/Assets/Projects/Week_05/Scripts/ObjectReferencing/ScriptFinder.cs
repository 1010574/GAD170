using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFinder : MonoBehaviour
{
    public static ScriptFinder ScriptFinderInstance; // an example of a static instance reference.

    private ScriptToFind scriptToFind; // a reference to the object transfor that has our script to find
    public Transform objectTransform; // a reference to the script to find.

    private void Awake()
    {
        ScriptFinderInstance = this; // "This" keyword refers to THIS instance of the script. 
    }


    // Start is called before the first frame update
    void Start()
    {
        scriptToFind = GetComponent<ScriptToFind>(); // this one will search the object that THIS script is attached to.
        scriptToFind = objectTransform.GetComponent<ScriptToFind>(); // this one will search objectTransform reference for the script that it is attached to
        scriptToFind = FindObjectOfType<ScriptToFind>(); // This one will find the first instance of the "ScriptToFind" script.
    }
    
}
