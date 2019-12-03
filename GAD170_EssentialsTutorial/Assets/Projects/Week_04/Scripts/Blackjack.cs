using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blackjack : MonoBehaviour
{
    public KeyCode hitMe = KeyCode.Mouse0; // Holds the keycode for the player to hit
    private int m_myCurrentScore; // Holds the current score
    private int m_myCurrentCardCount; // Holds the current card count
    private int m_myCardAverage; // holds the current average

    private const int BlackJackNumber = 21; // Constant to define blackjack

    // Start is called before the first frame update
    void Start()
    {
        ResetGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(hitMe))
        {
            HitMe();
            DetermineBlackjack();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ResetGame();
        }
    }

    /// <summary>
    /// Resets the game
    /// </summary>
    private void ResetGame()
    {
        m_myCardAverage = 0;
        m_myCurrentCardCount = 0;
        m_myCurrentScore = 0;
    }

    /// <summary>
    /// Determines if the player has hit black jack or if it is a good idea to hit again.
    /// </summary>
    private void DetermineBlackjack()
    {
        if (CheckIfBlackJack(m_myCurrentScore) == true)
        {
            Debug.Log("BLACKJACK - YOU WIN!");
        }
        else if (IsGreaterThanBlackJack(m_myCurrentScore) == true)
        {
            Debug.Log("BUST");
        }
        else
        {
            Debug.Log("Your Current Score Is: " + m_myCurrentScore + ". Your current card count is: " + m_myCurrentCardCount + ". The average is: " + m_myCardAverage + ".");
            if (IsGreaterThanBlackJack(m_myCurrentScore + m_myCardAverage))
            {
                Debug.Log("It would be unwise to Hit again...");
            }
            else
            {
                Debug.Log("It would be a good idea to Hit again...");
            }
        }
    }

    /// <summary>
    /// Takes our current score, draws a new card, adds it to our current score and current count.
    /// It then updates the average.
    /// </summary>
    private void HitMe() 
    {
        int tempCard = Random.Range(1, 11);
        m_myCurrentScore += tempCard;
        m_myCurrentCardCount ++;
        m_myCardAverage = CalculateAverage(m_myCurrentCardCount, m_myCurrentScore);

    }

    /// <summary>
    /// Checks to see if the value of the cards is greater than blackjack
    /// </summary>
    /// <param name="MyCurrentCardScore"></param>
    /// <returns></returns>
    private bool IsGreaterThanBlackJack(int MyCurrentCardScore)
    {
        if(MyCurrentCardScore > BlackJackNumber)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Checks to see if the number is exactly blackjack.
    /// </summary>
    /// <param name="MyCurrentCardScore"></param>
    /// <returns></returns>
    private bool CheckIfBlackJack(int MyCurrentCardScore)
    {
        if(MyCurrentCardScore == BlackJackNumber)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Calculate the average card value based on the number of cards the player has.
    ///  And the current total value of those cards
    ///  And returns the average of those.
    /// </summary>
    /// <param name="CurrentCardCount"></param>
    /// <param name="CurrentCardValue"></param>
    /// <returns></returns>
    private int CalculateAverage(int CurrentCardCount, int CurrentCardValue)
    {
        return CurrentCardValue / m_myCurrentCardCount;
    }

}
