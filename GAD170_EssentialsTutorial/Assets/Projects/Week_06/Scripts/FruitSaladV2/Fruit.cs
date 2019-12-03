using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public string fruitName; // the name of the fruit.
    public int numberOfSlices; // Number of slices to cut fruit into.
    public Color fruitColor; // Color of fruit
    public bool hasSeeds = false; // Does the fruit have seeds?

    /// <summary>
    /// Function to set up fruit with some default values.
    /// </summary>
    public void SetupFruit()
    {
        if (GetComponent<MeshRenderer>())
        {
            GetComponent<MeshRenderer>().material.color = fruitColor;
        }
        else
        {
            Debug.Log("No Mesh renderer component");
        }
    }

    /// <summary>
    /// Cuts the fruit into number of slices dictated by the instance.
    /// </summary>
    public void ChopFruit()
    {
        string finalMessage = hasSeeds == true ? "But I had to be careful as it had seeds" : "And it was delicious because it had no seeds";

        Debug.Log(string.Format("Cut the {0} into {1} slices, {2}", fruitName, numberOfSlices, finalMessage));
    }



  
}
