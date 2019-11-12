using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TippingScript : MonoBehaviour
{
    public float myMealCost = 0.0f;
    public float tipPercentage = 0.15f;
    public KeyCode calculateButton = KeyCode.Return;
    public float taxAmount = 0.10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(calculateButton))
        {
            CalculateTheTip(myMealCost, tipPercentage, taxAmount);
        }
    }
    /// <summary>
    /// Calculates the tip required to pay for my meal.
    /// </summary>
    /// <param name="Cost"></param>
    /// <param name="TipPercentage"></param>
    private void CalculateTheTip(float Cost, float TipPercentage, float TaxAmount)
    {
        Debug.Log("The Cost of my meal was $" + System.Math.Round (Cost + (ReturnSumOfNumbers(Cost, TipPercentage)) + (ReturnSumOfNumbers(Cost, TaxAmount)),2));
    }
    /// <summary>
    /// Returns the multiplied values of Num1 & Num2.
    /// </summary>
    /// <param name="Num1"></param>
    /// <param name="Num2"></param>
    /// <returns></returns>
    private float ReturnSumOfNumbers(float Num1, float Num2)
    {
        return Num1 * Num2;
    }
}
