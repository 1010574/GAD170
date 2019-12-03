using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int coinsCollected = 0;
    private PlayerInput player;


    // Start is called before the first frame update
    void Start()
    {
        // gets a reference to out player input.
        player = FindObjectOfType<PlayerInput>();
    }

    /// <summary>
    /// Resets all scripts in game.
    /// </summary>
    public void ResetGame()
    {
        player.Reset();
        coinsCollected = 0;
        ResetCoins();

        // Another way we could reset our game.
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    /// <summary>
    /// Finds all the coins in my scene and resets them.
    /// </summary>
    private void ResetCoins()
    {
        Coin[] coins = FindObjectsOfType<Coin>();
        for(int i=0; i< coins.Length; i++)
        {
            coins[i].Reset();
        }
    }

    /// <summary>
    /// Adds the amount of coins to our coins collected.
    /// </summary>
    /// <param name="value"></param>
    public void CollectCoin(int value)
    {
        coinsCollected += value;
    }


}
