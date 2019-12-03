using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thanos : MonoBehaviour
{
    public int health = 100; // Holds Thanos's health.

    /// <summary>
    /// Function to deal some damage to thanos
    /// </summary>
    /// <param name="Damage"></param>
    public void DealDamage(int Damage)
    {
        // This can be used to heal him as well if positive numbers are input.
        health += Damage;
    }

   
}
