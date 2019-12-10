using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week08Recap : MonoBehaviour
{
    public List<GameObject> peopleIKnow = new List<GameObject>(); // List of all people I know
    public Dictionary<string, GameObject> people = new Dictionary<string, GameObject>(); // Dictionary is a key value system, where I can use the key to access a value

    // Start is called before the first frame update
    void Start()
    {
        // Loop through all the people I know and add new entries to the dictionary for each.
        // Gameobject name as the key, and the game object itself as the value.
        for (int i = 0; i < peopleIKnow.Count; i++)
        {
            // this is how to add something to dictionary
            people.Add(peopleIKnow[i].name, peopleIKnow[i]);
        }

        PrintDictionary();

        // This is how we can remove an element from a dictionary
        people.Remove("Moe");

        PrintDictionary();

        // The unsafe method to access element in dictionary is:
        people["Curly"].GetComponent<MeshRenderer>().material.color = Color.red;

        // Safe way of accessing element in dictionary is:
        GameObject objectTryToGet;
        if(people.TryGetValue("Larry", out objectTryToGet))
        {
            objectTryToGet.GetComponent<MeshRenderer>().material.color = Color.cyan;
        }
        else
        {
            Debug.Log("No Larry here");
        }

    }
    
    /// <summary>
    /// Goes through each element of my dictionary and prints out the key and value
    /// </summary>
    private void PrintDictionary()
    {
        foreach(KeyValuePair<string, GameObject> dictionary in people)
        {
            Debug.Log("Key is:" + dictionary.Key + ". Value is: " + dictionary.Value);
        }
    }

}
