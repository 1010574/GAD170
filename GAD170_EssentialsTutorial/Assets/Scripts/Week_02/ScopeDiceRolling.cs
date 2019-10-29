using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeDiceRolling : MonoBehaviour
{
    public int myDiceRoll = 0; // This is the current number the dice is.
    public int myMinDiceRoll = 1; // The minimum number the dice could be
    public int myMaxDiceRoll = 6; // The maximum number the dice could be
    [TooltipAttribute ("The key used for rolling the dice.")]
    public KeyCode rollInputKey; // the input we use to start rolling our dice.

    // Start is called before the first frame update
    void Start()
    {
        // An exmaple of scope, this variable myCurrentDiceRoll
        // only exists within these Start{} parenthesis. If you try
        // to access it on a different level / layer of {} then it won't be accessible.
        int myCurrentDiceRoll = 0;
        if(myCurrentDiceRoll > 0)
        {
            myCurrentDiceRoll = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Checks to see if input key is pressed
        // If it is, get a random number for my dice roll.
        if (Input.GetKeyDown(rollInputKey))
        {
            // Lets create a temporary variable to hold my current dice roll.
            int myCurrentDiceRoll = Random.Range(myMinDiceRoll, myMaxDiceRoll + 1);
            myDiceRoll = myCurrentDiceRoll;
            Debug.Log("My dice roll is: " + myDiceRoll);

            // Displays the % chance of rolling number. When dividing float by float, return is float
            // if dividing int by int, return will be int.
            Debug.Log("The chance of getting this number is: " + (1f / 6f) + "%");

            if(myDiceRoll < 3)
            {
                Debug.Log("Dice roll is less than 3");
            }
            else if (myDiceRoll > 3 && myDiceRoll < 5)
            {
                Debug.Log("Dice roll is greater than 3 but less than 5");
            }
            else
            {
                Debug.Log("Dice roll is 6");
            }

        }
    }
}
