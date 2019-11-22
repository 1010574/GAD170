using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListsAndArrays : MonoBehaviour
{
    // the basic anatomy of an array is:
    // Access Type
    // Data type (int, string, bool, etc.) followed by [] to say it's an array
    // then variable name.
    public int[] myFirstIntArray; // An array to hold our ints. An array is a collection of items. 

    // the basic anatomy of a list is:
    // access type
    // List<datatype>
    // Variable Name
    // Then we have to initialise it with an empty list, using the "new" keyword to get a new instance of our list class. 
    public List<int> myFirstIntList = new List<int>(); // A list to hold a collection of items.



    // Start is called before the first frame update
    void Start()
    {
        // Examples of accessing an element of an array.
        // Arrays always start at element 0.
        // The easiest way to remember which element to access is, whatever position you want minus 1. I.e. If accessing position 4, i need element 3.
        Debug.Log("The First number in my Array is: " + myFirstIntArray[0]);
        Debug.Log("The Second number in my Array is: " + myFirstIntArray[1]);
        Debug.Log("The Third number in my Array is: " + myFirstIntArray[2]);

        // An example of adding an element to an array.
        myFirstIntArray = new int[] { 5, 4, 2, 7 };
        // An example of removing an element from an array.
        myFirstIntArray = new int[] { 5, 2, 7 };
        // an example of getting the length of an array (how many items are in it)
        Debug.Log(myFirstIntArray.Length);


        // an example of accessing an element in a list. Same behaviour as an array.
        Debug.Log("The First number in my List is: " + myFirstIntList[0]);
        Debug.Log("The Second number in my List is: " + myFirstIntList[1]);
        Debug.Log("The Third number in my List is: " + myFirstIntList[2]);

        // an example of adding an element to a list.
        myFirstIntList.Add(4);
        // an example of removing an element from a list. 
        myFirstIntList.Remove(12);
        // an example of using "RemoveAt" - removes the item from the element I define. In this case, it is the last element in my list. 
        // List.Count returns how long a list is. 
        myFirstIntList.RemoveAt(myFirstIntList.Count - 1);

        // This is an example of accessing a randomg element from my array or list. 
        // The key here is random.range for ints is exclusive, meaning that what ever number is the max, it will be minus 1.
        // This is excellent for us as arrays/lists start and position 0, so or list of 9 long has 8 elements. 
        // If we did a random range between 0 and 9, we could only get a number between 0 and 8 - meaning we won't get an "element out of range" error. 
        Debug.Log("Accessing a random element from my List " + myFirstIntList[Random.Range(0, myFirstIntList.Count)]);

    }
}
