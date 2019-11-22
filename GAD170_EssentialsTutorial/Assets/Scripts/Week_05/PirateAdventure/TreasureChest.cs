using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    public int minGold;
    public int maxGold;

    public bool isGettingTreasure = false;
    

    public void SearchForTreasure()
    {
        if(CoinFlip() == true)
        {
            Debug.Log("Treasure Found!" + GoldFound(minGold, maxGold);
        }
        else
        {
            Debug.Log("No Treasure Found keep looking!");
        }
    }

    /// <summary>
    /// Returns random number between min and max
    /// </summary>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <returns></returns>
    public int GoldFound(int min, int max)
    {
        return Random.Range(min, max);
    }

    /// <summary>
    /// Returns true if heads, returns false if tails.
    /// </summary>
    /// <returns></returns>
    private bool CoinFlip()
    {
        int coinFlip = Random.Range(1, 3);

        if (coinFlip == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
