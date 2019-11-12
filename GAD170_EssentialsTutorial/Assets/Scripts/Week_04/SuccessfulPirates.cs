using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessfulPirates : MonoBehaviour
{
    public KeyCode digKey = KeyCode.Mouse0; // the button to dig.
    public float percentageRequiredToFindGold = 66.66f; // the percentage to find gold.
    public int numberOfCrew = 11; // The number of crew including the captain.

    private const float captainShare = 0.20f; // The captains share of profit.

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(digKey))
        {
            Dig();
        }
    }
    /// <summary>
    /// Creates a random chance of finding gold, and checks it against what is required. 
    /// If gold is found, calculates the split of the gold.
    /// </summary>
    private void Dig()
    {
        float randomNumber = Random.Range(0f, 101f);

        if(randomNumber >= percentageRequiredToFindGold)
        {
            Debug.Log("You have found gold!");
            CalculateBootySplit(Random.Range(20, 101), numberOfCrew, captainShare);
            
        }
        else
        {
            Debug.Log("No Gold Found :/");
        }
    }
    /// <summary>
    /// Calculates the gold split amongst the captain and the crew
    /// </summary>
    /// <param name="AmountOfGold"></param>
    private void CalculateBootySplit(int AmountOfGold, int NumberOfCrew, float CaptainsShare)
    {
        int startingGold = AmountOfGold;
        int captainsShare = (int)(AmountOfGold * CaptainsShare);
        AmountOfGold -= captainsShare; // take away the captains share from the gold found.
        int amountToEachCrewMember = (int)((float)AmountOfGold / ((float)numberOfCrew - 1)); // Calculates average gold to each crew member minus captain

        Debug.Log("The Booty was " + startingGold + ". The Split was: " + captainsShare + " to the Captain, the rest of the crew got: " + amountToEachCrewMember + " each!");
    }
}
