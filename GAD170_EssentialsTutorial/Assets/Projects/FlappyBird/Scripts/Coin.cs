using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;
    private GameManager gameManager;
    private Collider myCollider;
    private MeshRenderer myRenderer;
    private AudioManager audioManager;

    // Start is called before the first frame update
    void Start()
    {
        coinValue = Random.Range(1, 6);
        gameManager = FindObjectOfType<GameManager>();
        myCollider = GetComponent<Collider>();
        myRenderer = GetComponent<MeshRenderer>();
        audioManager = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// This handles triggers and detects the collider.
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        // Checks to see if the object passing through it has the tag "Player"
        if (other.transform.tag == "Player")
        {
            gameManager.CollectCoin(coinValue);
            audioManager.CollectCoin();
            myCollider.enabled = false;
            myRenderer.enabled = false;
            
           
        }

        /*
         * Another way to check to see if it is the player colliding with the triggert.
        if (other.transform.GetComponent<PlayerInput>())
        {
            gameManager.CollectCoin(coinValue);
            myCollider.enabled = false;
            myRenderer.enabled = false;
        }
        */
    }

    /// <summary>
    /// Resets our coin so we an collect it again on death.
    /// </summary>
    public void Reset()
    {
        myCollider.enabled = true;
        myRenderer.enabled = true;
        coinValue = Random.Range(1, 6);
    }
}
