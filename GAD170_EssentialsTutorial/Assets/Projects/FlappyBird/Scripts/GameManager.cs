using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int currentScore = 0;

    public int CurrentScore
    {
        get
        {
            return currentScore;
        }
        set
        {
            currentScore = value;
            uiManager.UpdateScore(currentScore);
        }
    }
    private PlayerInput player;
    private ColumnSpawner spawningColumns;
    private UIManager uiManager;


    // Start is called before the first frame update
    void Start()
    {
        // gets a reference to out player input.
        player = FindObjectOfType<PlayerInput>();
        spawningColumns = FindObjectOfType<ColumnSpawner>();
        uiManager = FindObjectOfType<UIManager>();
        
    }

    /// <summary>
    /// Resets all scripts in game.
    /// </summary>
    public void ResetGame()
    {
        player.Reset();
        ResetCameras();
        CurrentScore = 0;
        ResetCoins();
        spawningColumns.Reset();

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
    /// Finds all camera scripts in scene and resets them.
    /// </summary>
    private void ResetCameras()
    {
        CameraScript[] cams = FindObjectsOfType<CameraScript>();

        for(int i=0; i < cams.Length; i++)
        {
            cams[i].Reset();
        }

    }

    /// <summary>
    /// Adds the amount of coins to our coins collected.
    /// </summary>
    /// <param name="value"></param>
    public void CollectCoin(int value)
    {
        CurrentScore += value;
    }


}
