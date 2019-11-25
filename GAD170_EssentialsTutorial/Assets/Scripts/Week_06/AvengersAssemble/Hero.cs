using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{

    public string heroName; // The heroes name
    public string weapon; //  The heroes weapon
    public int weaponDamage = 5; // The damage of the weapon.

    /// <summary>
    /// Sets the damage to a random amount
    /// </summary>
    private void Start()
    {
        weaponDamage = Random.Range(0, 21);
    }

    /// <summary>
    /// Returns the amount of damage caused
    /// </summary>
    /// <returns></returns>
    public int ReturnDamage()
    {
        Debug.Log("Damage Thanos with " + weapon + " it dealt " + weaponDamage + " damage");
        return weaponDamage;
    }
}
