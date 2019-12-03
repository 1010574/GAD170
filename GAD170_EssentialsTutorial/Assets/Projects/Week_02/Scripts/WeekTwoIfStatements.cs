using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoIfStatements : MonoBehaviour
{
    public string myName = "Kyle"; //  Variable to hold my name
    public bool likesCoffee = true; // Does the user like coffee?
    public int myFavouriteNumber = 13; // Favourite number of user
    public float myFavouriteFloat = 6.666f; // favourite float of the user

    // Start is called before the first frame update
    void Start()
    {
        /// Anatomy of an if statement is:
        /// if
        /// A condition i.e. (value inside of likesCoffee is equal to true)
        /// then do what ever is inside of the curly braces {}
        if(likesCoffee == true)
        {
            Debug.Log(myName + " Likes Coffee.");
        }

        // An example of a false condition being true.
        if (likesCoffee == false)
        {
            Debug.Log(myName + " Does not like coffee");
        }

        // An example of a string condition being true.
        if(myName == "StaceysMum")
        {
            Debug.Log("Stacey can't you see, you're just not the girl for me");
        }

        // An example of a string condition being true.
        if (myName != "StaceysMum")
        {
            Debug.Log("Your name is Kyle");
            
        }

        // An example of an Int equalling exactly 13 being true
        if(myFavouriteNumber == 13)
        {
            Debug.Log("Is exactly 13");
        }

        // An example of a number being less than or equal to 5
        if(myFavouriteNumber < 5)
        {
            Debug.Log("Your naumber is less than 5");
        }

        // An example of a float being greater than 5
        if(myFavouriteFloat > 5)
        {
            Debug.Log("Your number is greater than 5");
        }


        // Examples of multiple conditions
        if(myName == "Kyle" && likesCoffee == true)
        {
            Debug.Log("Kyle likes coffee");
        }

        // An example of an && condition. If both conditions are true, then execute code.
        if(myName != "Kyle" && likesCoffee == false)
        {
            Debug.Log("You are not Kyle and you don't like coffee");
        }

        // An example of || (or) condition. If one condition is true, then execute code.
        if(myFavouriteNumber < 4 || myFavouriteNumber > 6)
        {
            Debug.Log("My favourite number is less than 4 or greater than 6");
        }

        // An example of nesting multiple If statements with multiple conditions.
        if(likesCoffee == true)
        {
            if(myName == "Kyle")
            {
                Debug.Log("Kyle Really Likes Coffee");
            }
            if(myName != "Kyle")
            {
                Debug.Log("Not Kyle");
            }
            if (myFavouriteNumber > 4 && myFavouriteNumber < 14)
            {
                Debug.Log("And my favourite number is: " + myFavouriteNumber);
            }
        }
    }
}
