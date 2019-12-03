using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmProblem : MonoBehaviour
{
    public int numberOfCows = 2; // The number of cows
    public int numberOfChickens = 2; // The Number of chickens
    public int numberOfHorses = 2; // the number of horses
    private const int m_TwoLegs = 2; // constant values for possible legs
    private const int m_FourLegs = 4; // constant values for possible legs

    // Start is called before the first frame update
    void Start()
    {
        PrintFarmYard(numberOfCows, numberOfHorses, numberOfChickens);
        PrintFarmYard(numberOfCows * 2, numberOfHorses / 2, numberOfChickens - 1);
    }

    /// <summary>
    /// Prints the count of all the farm animals legs that are on my farm.
    /// </summary>
    /// <param name="NumCows"></param>
    /// <param name="NumHorse"></param>
    /// <param name="NumChickens"></param>
    public void PrintFarmYard(int NumCows, int NumHorse, int NumChickens)
    {
       int numberOfLegs = CalculateAllLegs(NumCows, NumHorse, NumChickens);

        string myDebugMessage = string.Format("My farm has {0} cows, each have {1} legs. It also has {2} Chickens, each with " +
            "{3} legs. Finally, I have {4} Horses, each has {5} legs. This means I have a total of {6} Legs.", NumCows, 4, NumChickens, 2, NumHorse, 4, numberOfLegs);

        Debug.Log(myDebugMessage);
    }
    /// <summary>
    /// Takes in a number of animals and multiplies by the constants of the legs they have, and adds them together.
    /// </summary>
    /// <param name="NumCows"></param>
    /// <param name="NumHorses"></param>
    /// <param name="NumChickens"></param>
    /// <returns></returns>
    private int CalculateAllLegs(int NumCows, int NumHorses, int NumChickens)
    {
        return (NumCows * m_FourLegs) + (NumHorses * m_FourLegs) + (NumChickens * m_TwoLegs);
    }
}
