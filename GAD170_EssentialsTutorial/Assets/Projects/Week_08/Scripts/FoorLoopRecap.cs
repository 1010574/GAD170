using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoorLoopRecap : MonoBehaviour
{
    public List<int> numbersList = new List<int>();
    public List<int> secondNumbersList = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        AddFirstTenNumbers();
        AddUpToN(10);
        AddUpToN(6000);
        AddAllNumbersInList();
        AddAllNumbersInAnotherList(secondNumbersList);
    }

    /// <summary>
    /// A specific list of numberList is used and adds the numbers up.
    /// </summary>
    public void AddAllNumbersInList()
    {
        int totalSum = 0;   

        // My list has 4 elements
        // 0, 1, 2, 3
        // Lists start at element 0
        for(int i=0; i<numbersList.Count; i++)
        {
            totalSum += numbersList[i];
        }
        Debug.Log("Total sum:" + totalSum);
    }

    /// <summary>
    /// A Generic function that can take in any list and add all numbers.
    /// </summary>
    /// <param name="myList"></param>
    public void AddAllNumbersInAnotherList(List<int> myList)
    {
        int totalSum = 0;

        // My list has 4 elements
        // 0, 1, 2, 3
        // Lists start at element 0
        for (int i = 0; i < myList.Count; i++)
        {
            totalSum += myList[i];
        }
        Debug.Log("Total sum:" + totalSum);
    }

    /// <summary>
    /// Adds the first ten numbers in succession together and debugs out the sum
    /// </summary>
    public void AddFirstTenNumbers()
    {
        int totalSum = 0;

       // totalSum = 0 + 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10;

        // Start with "For" to let unity know we want to use a for loop.
        // Then start with a temp variable to say where we want to start our loop from.
        // Then a condition of when the loop should stop.
        // Then we tell the loop how we want to iterate our "i" value. In this case, just add 1.
        for(int i = 0; i < 11; i++)
        {
            totalSum += i;
            Debug.Log("Total Sum: " + totalSum);
        }

        Debug.Log("The first ten numbers total sum is: " + totalSum);
    }

    /// <summary>
    /// Adds the numbers up to the number in the parameter.
    /// </summary>
    /// <param name="NumberUpTo"></param>
    public void AddUpToN(int NumberUpTo)
    {
        int totalSum = 0;

        for(int i = 0; i<=NumberUpTo; i++)
        {
            totalSum += i;
        }
        Debug.Log("Total sum:" + totalSum);
    }
}
