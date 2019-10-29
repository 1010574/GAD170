using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoCoffeeMachine : MonoBehaviour
{
    [Header("Coffee Types")]
    public bool isCappuchino = false; // Set to true if cappuchino is selected
    public bool isFlatWhite = false; // Set to true if flat white is selected
    public bool isLongBlack = false; // set to true if long black is selected

    [Header("Milk Types")]
    public bool isMilkFullCream = false; // set to true if full cream milk is selected
    public bool isMilkSkim = false; // set to true if skim milk is selected
    public bool isNoMilk = false; // set to true if a Long Black is selected

    [Header("Number of Sugars")]
    public int howManySugars = 0; // Used to hold how many sugars customer wants

    public bool isCoffeeSelected = false; // is set to true once user has selected coffee
    private bool hasCoffeeBeenAsked = false; // is set to true once asked what coffee wanted
    public bool hasMilkBeenSelected = false; // is set to true once milk has been selected
    public bool hasMilkBeenAsked = false; // set to true if milk has been asked
    public bool hasSugarsBeenAsked = false; // set to true once sugar has been asked
    public bool hasSugarBeenInput = false; // set to true once sugars input
    public bool hasOrderFinsished = false; // set to true once order finished

    // Update is called once per frame
    void Update()
    {
        if (hasCoffeeBeenAsked == false)
        {
            //Introduce cafe
            Debug.Log("Welcome to Kyles Super-Duper Dope Cafe");
            Debug.Log("What kind of coffee would you like? \n 1: Cappuchino \n 2: Flat White \n 3: Long Black");
            hasCoffeeBeenAsked = true;
        }
        // lets check to see what coffee order people want
        else if (hasCoffeeBeenAsked == true && isCoffeeSelected == false)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
            {
                // Selected cappuchino
                isCappuchino = true;
                isFlatWhite = false;
                isLongBlack = false;
                isCoffeeSelected = true;
                Debug.Log("Cappuchino Selected!");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
            {
                // selected flat white
                isCappuchino = false;
                isFlatWhite = true;
                isLongBlack = false;
                isCoffeeSelected = true;
                Debug.Log("Flat White Selected!");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
            {
                // selected long black
                isCappuchino = false;
                isFlatWhite = false;
                isLongBlack = true;
                isCoffeeSelected = true;
                Debug.Log("Long Black Selected!");
            }

        }
        else if (hasMilkBeenAsked == false)
        {
            if (isLongBlack == false)
            {
                Debug.Log("What kind of milk would you like? \n 1: Full Cream \n 2: Skim");
            }
            hasMilkBeenAsked = true;
        }
        else if (isCoffeeSelected && hasMilkBeenSelected == false && hasMilkBeenAsked == true)
        {
            //Check what milk people want...
            if (isLongBlack == true)
            {
                // this is a long black, no milk required. Skip this step.
                Debug.Log("Coffee is a Long Black - No Milk required!");
                isNoMilk = true;
                isMilkFullCream = false;
                isMilkSkim = false;
                hasMilkBeenSelected = true;
            }

            else
            {
                // Check what milk people want
                if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
                {
                    // Selected Full Cream
                    isMilkFullCream = true;
                    isMilkSkim = false;
                    isNoMilk = false;
                    hasMilkBeenSelected = true;
                    Debug.Log("Full Cream Milk Selected!");
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
                {
                    // selected Skim
                    isMilkSkim = true;
                    isMilkFullCream = false;
                    isNoMilk = false;
                    hasMilkBeenSelected = true;

                    Debug.Log("Skim Milk Selected!");
                }
            }
        }
        else if (hasSugarsBeenAsked == false && hasSugarBeenInput == false)
        {
            Debug.Log("How many sugars would you like? \n 1: One Sugar \n 2: Two Sugars \n 3: Three Sugars");
            hasSugarsBeenAsked = true;

        }
        else if (hasSugarBeenInput == false && hasSugarsBeenAsked == true)
        {
            // Lets check to see how many sugars people want
            if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
            {
                // Selected 1 sugar
                howManySugars = 1;
                hasSugarBeenInput = true;
                Debug.Log("1 Sugar Selected!");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
            {
                // selected 2 sugars
                howManySugars = 2;
                hasSugarBeenInput = true;
                Debug.Log("2 Sugars Selected!");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
            {
                // selected 3 sugars
                howManySugars = 3;
                hasSugarBeenInput = true;
                Debug.Log("3 Sugars Selected!");
            }
        }
        else if (hasOrderFinsished == false && hasSugarBeenInput == true)
        {
            Debug.Log("Here is your coffee, sorry for the delay!");
            hasOrderFinsished = true;
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isCappuchino = false; // Set to true if cappuchino is selected
            isFlatWhite = false; // Set to true if flat white is selected
            isLongBlack = false; // set to true if long black is selected
            isMilkFullCream = false; // set to true if full cream milk is selected
            isMilkSkim = false; // set to true if skim milk is selected
            isNoMilk = false;
            howManySugars = 0; // Used to hold how many sugars customer wants
            isCoffeeSelected = false; // is set to true once user has selected coffee
            hasCoffeeBeenAsked = false; // is set to true once asked what coffee wanted
            hasMilkBeenSelected = false; // is set to true once milk has been selected
            hasMilkBeenAsked = false; // set to true if milk has been asked
            hasSugarsBeenAsked = false; // set to true once sugar has been asked
            hasSugarBeenInput = false; // set to true once sugars input
            hasOrderFinsished = false; // set to true once order finished
        }
    }
}
