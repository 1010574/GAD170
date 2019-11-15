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
    /// An example of a get and a set, essentially access type, data type, name. 
    /// Behaves like a return function, but can do different things based on how it is used.
    /// I.E getting the value or setting the value.
    /// </summary>
    public int Health
    {
        get
        {
            // May want to do something here like return damage effects???
            return health;
        }
        set
        {
            // when this value is set, update the UI.
            // Decrease/Increase the blood splatter effect.
            health = value;
        }
    }

    public string FullName
    {
        get
        {
            Debug.Log("My full name is: " + m_fullName);
            return m_fullName;
        }
        set
        {
            Debug.Log(value);
            m_fullName = value;
        }
    }

    /// <summary>
    /// Sets the instance enemy class with some default values.
    /// </summary>
    public void SetUpEnemy()
    {
        myFirstName = "Kyle";
        myLastName = "Lyon";
        Health = 100;
        mana = 100;
        m_fullName = myLastName + " " + myLastName;

        // An example of using Set
        FullName = "Kyle";

        //An example of Get
        Debug.Log("Testing Get" + FullName);

    }
}
