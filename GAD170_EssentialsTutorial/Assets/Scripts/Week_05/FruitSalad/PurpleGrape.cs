using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleGrape : MonoBehaviour
{

    public int numberOfSlices; // the number of slices I will be cutting this fruit into.
    public Color fruitColor; // the color of the fruit.
    public bool hasSeeds = true; // if the fruit has seeds.

    /// <summary>
    /// This sets up the fruit for our fruit salad. 
    /// </summary>
    public void SetUpFruit()
    {
        if (GetComponent<MeshRenderer>())
        {
            GetComponent<MeshRenderer>().material.color = fruitColor;
        }
        else
        {
            Debug.Log("No mesh render component");
        }
    }

    /// <summary>
    /// Cuts the fruit up into the number of slices dictated by the script.
    /// </summary>
    public void ChopFruit()
    {
        string finalMessage = hasSeeds == true ? "but I had to be careful because it has seeds" : "I skinned it, and it had no seeds";

        Debug.Log(string.Format("Cut the {0} into {1} slices, {2}", this.name, numberOfSlices, finalMessage));
    }

}