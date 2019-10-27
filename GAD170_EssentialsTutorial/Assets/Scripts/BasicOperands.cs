using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicOperands : MonoBehaviour
{
    public string myName = "Kyle";
    public int myAgeInYears = 27;
    public int myAgeInMonths = 0;
    public int myAgeInWeeks = 0;
    public int myAgeInDays = 0;
    public int myBirthdayDay = 13;
    public int myBirthdayMonth = 04;
    public int myBirthdayYear = 1992;

    // Start is called before the first frame update
    void Start()
    {
        string myDebugMessage = "My name is: " + myName + " my birthday is: " + myBirthdayDay + "/" + myBirthdayMonth + "/" + myBirthdayYear;
        myDebugMessage = myDebugMessage + " my age in years is: " + myAgeInYears;

        myAgeInMonths = myAgeInYears * 12;
        Debug.Log("My Age in Months is: " + myAgeInMonths);
        myAgeInWeeks = myAgeInMonths * 4;
        myAgeInDays = myAgeInWeeks * 7;

        myDebugMessage += " my age in months: " + myAgeInMonths;
        myDebugMessage += " My age in weeks: " + myAgeInWeeks;
        myDebugMessage += " my age in days: " + myAgeInDays;

       
        
        Debug.Log(myDebugMessage);
        Debug.Log("This is an example of Modulos, it divides a number evenly and returns the remainder which is: " + myAgeInDays % 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
