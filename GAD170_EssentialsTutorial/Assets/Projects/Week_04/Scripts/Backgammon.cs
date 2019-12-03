using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgammon : MonoBehaviour
{
    public enum PlayersTurn {PlayerOne, PlayerTwo};
    public PlayersTurn currentPlayerTurn;

    public KeyCode rollDiceButton = KeyCode.Mouse0; // The button to roll dice
    public KeyCode resetButton = KeyCode.Escape; // the button to reset game

    public int playerOneScore = 0; // player one score
    public int playerTwoScore = 0; // player two score

    public int maxScore = 20; // max score of game
    public bool gameOver = false; // is the game over?

    // Start is called before the first frame update
    void Start()
    {
        ResetGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(rollDiceButton) && !gameOver)
        {
            RollDice();
        }

        if(gameOver == true && Input.GetKeyDown(resetButton))
        {
            ResetGame();
        }
    }

    /// <summary>
    /// Resets game to starting values
    /// </summary>
    private void ResetGame()
    {
        playerOneScore = 0;
        playerTwoScore = 0;
        currentPlayerTurn = PlayersTurn.PlayerOne;
        gameOver = false;
    }

    /// <summary>
    /// This function will roll 2 dice, and then calculate overall player score.
    /// </summary>
    private void RollDice()
    {
       if (currentPlayerTurn == PlayersTurn.PlayerOne)
        {
            playerOneScore += ReturnBackgammonDiceRollsResult(ReturnDiceRoll(), ReturnDiceRoll());
        }
        else
        {
            playerTwoScore += ReturnBackgammonDiceRollsResult(ReturnDiceRoll(), ReturnDiceRoll());
        }

        CheckGameStatus();
        // An example of a short hand if statement.
        currentPlayerTurn = currentPlayerTurn == PlayersTurn.PlayerOne ? PlayersTurn.PlayerTwo : PlayersTurn.PlayerOne;       
    }

    /// <summary>
    /// Checks if win condition has occured.
    /// </summary>
    private void CheckGameStatus()
    {
        if(gameOver == true)
        {
            return;
        }
        if(playerOneScore >= maxScore)
        {
            gameOver = true;
            Debug.Log("Player One Wins!");
        }
        else if(playerTwoScore >= maxScore)
        {
            gameOver = true;
            Debug.Log("Player Two Wins!");
        }
    }

    /// <summary>
    /// This function takes in two dice rolls, then based on the mechanics of backgammon,
    /// then the result return will be the players score.
    /// </summary>
    /// <param name="Num1"></param>
    /// <param name="Num2"></param>
    /// <returns></returns>
    private int ReturnBackgammonDiceRollsResult(int Num1, int Num2)
    {
        if(Num1 == Num2)
        {
            return (Num1 + Num2) * 2;
        }
        else
        {
            return (Num1 + Num2);
        }        
    }

    /// <summary>
    /// returns a random number between 0 and 6
    /// </summary>
    /// <returns></returns>
    private int ReturnDiceRoll(int min = 0, int max = 6)
    {
        return Random.Range(min, max);
    }
}
