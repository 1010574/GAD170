using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoIfElseStatements : MonoBehaviour
{
    public string myName; // String to hold My Name
    public string myCarColour = "HotPink"; // String to hold my car's colour
    public bool likesCoffee = true; // Bool to state if I like coffee or not
    public int myAge = 27; // Int to hold my age

    // Start is called before the first frame update
    void Start()
    {
        // Checks to see if name is Kyle
        // Otherwise they are not Kyle
        if(myName == "Kyle")
        {
            Debug.Log("You are Kyle");
        }
        else
        {
            Debug.Log("You are not Kyle");
        }

        // Check to see if age is less than 27 and greater than 5
        // Otherwise, age does not fall between these
        if(myAge < 27 && myAge > 5)
        {
            Debug.Log("Your age is between 27 and 5");
        }
        else
        {
            Debug.Log("Your age is not between 27 and 5");
        }

        // Checks to see if age is greater than 5
        if(myAge > 5)
        {
            Debug.Log("Your age is greater than 5");
        }

        // Checks to see if age is less than 27. Is example of single IF statement
        if (myAge < 27)
        {
            Debug.Log("Your age is less than 27");
        }

        // An example of a nested IF ELSE IF statement
        // If my name is not Kyle or my car color is HotPink
        if(myName != "Kyle" || myCarColour == "HotPink")
        {
            // Do this
            Debug.Log("You are not Kyle or your car is HotPink");
            // If the user likes coffee, than log that out
            if(likesCoffee == true)
            {
                Debug.Log("You Like Coffee!!");
            }
            else
            {
                // Otherwise log out that they don't like coffee.
                Debug.Log("You don't like coffe?? What's wrong with you!?");
                // Then check age
                if (myAge > 27)
                {
                    Debug.Log("You are older than Kyle!");
                }
                else
                {
                    Debug.Log("You are younger than Kyle!");
                }
            }
        }

    }
}
