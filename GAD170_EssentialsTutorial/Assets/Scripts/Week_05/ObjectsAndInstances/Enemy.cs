using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string myFirstName; // enemies first name
    public string myLastName; // enemies last name
    public int health; // enemies health    
    public int mana; // enemies mana

    private string m_fullName; // enemies full name, private variable. Cant be seen in EnemyManager

    /// <summary>
    /// Sets the instance enemy class with some default values.
    /// </summary>
    public void SetUpEnemy()
    {
        myFirstName = "Kyle";
        myLastName = "Lyon";
        health = 100;
        mana = 100;
        m_fullName = myLastName + " " + myLastName;
    }
}
