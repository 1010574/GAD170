using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoIfElseIfStatemnts : MonoBehaviour
{
    public string myName = "Kyle"; // Users name
    public string myCarColour = "Pee Yellow"; // users car colour
    public bool likesCoffee = true; // does the user like coffee?
    public int myAge = 27; // The users age

    // Start is called before the first frame update
    void Start()
    {
        // Checks if user likes coffe is true.
        if (likesCoffee)
        {
            Debug.Log("Likes coffee!");
        }

        // checks to see if my age is greater than 5, otherwise it is not
        if(myAge > 5)
        {
            Debug.Log("My age is greater than 5");
        }
        else
        {
            Debug.Log("My age is less than 5");
        }

        // checks to see if my age is greater than 27, else it checks to see if it is less than 26
        if(myAge > 27)
        {
            Debug.Log("Age is greater than 27");
        }
        else if(myAge < 26)
        {
            Debug.Log("My age is less than 26");
        }

        // If my car colour is poo brown
        // Else if it checks to see if it is yellow then checks if user doesn't like coffee
        // otherwise checks if it's purple otherwise it's some other colour.
        if (myCarColour == "Poo Brown")
        {
            Debug.Log("Car is Poo Brown");
        }
        else if(myCarColour == "yellow")
        {
            Debug.Log("My car is Yellow");
            if (!likesCoffee)
            {
                Debug.Log("I don't like coffee");
            }
        }
        else
        {
            if(myCarColour == "Purple")
            {
                Debug.Log("Car colour is Purple");
            }
            else
            {
                Debug.Log("Car is some other colour");
            }
        }
    }
}
