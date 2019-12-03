using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FruitBowlV2 : MonoBehaviour
{
    public List<Fruit> allFruit = new List<Fruit>();

    // Start is called before the first frame update
    void Start()
    {
        // an example of converting an array into a list using system.linq
        allFruit = FindObjectsOfType<Fruit>().ToList();


        // An example of converting an array into a list.
        Fruit[] tempArray = FindObjectsOfType<Fruit>();
        List<Fruit> templist = new List<Fruit>();
        for(int i =0; i< tempArray.Length; i++)
        {
            templist.Add(tempArray[i]);
        }

        // This iterates through my list of fruit
        for(int i=0; i <allFruit.Count; i++)
        {
            // for each element of fruit, set it up.
            allFruit[i].SetupFruit();
            // for each element of fruit, chop it.
            // An example of limiting what gets chopped..
            if(allFruit[i].fruitName == "Apple")
            {
                allFruit[i].ChopFruit();

            }
        }
    }

}
