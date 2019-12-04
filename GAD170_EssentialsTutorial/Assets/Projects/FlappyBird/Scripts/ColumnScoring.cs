using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnScoring : MonoBehaviour
{
    public int scoreValue = 1; // value get when score zone entered
    private GameManager m_GameManager;

    private void Start()
    {
        m_GameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //if player enters the trigger.
        if (other.transform.GetComponent<PlayerInput>())
        {
            // adds to score
            m_GameManager.CollectCoin(1);
        }
    }
}
