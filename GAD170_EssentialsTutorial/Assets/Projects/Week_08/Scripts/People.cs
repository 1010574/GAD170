using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : MonoBehaviour
{
    public int health = 100;
    public bool dead;
    private ArraysAndListsRecap arraysAndListsRecap;

    public void SetUp()
    {
        health = 100;
        arraysAndListsRecap = FindObjectOfType<ArraysAndListsRecap>(); // searches the scene for an instance of the Arrays and Lists Recap script.
    }

    public void Attack(People PersonToAttack)
    {
        if (dead)
        {
            return;
        }
       
        // Deals -1 to -200 damage to the opposing person
        PersonToAttack.DealDamage(Random.Range(-1, -200));
        // Using the same function, I'm healing myself every time I attack.
        DealDamage(Random.Range(10, 25));
        
    }

    public void DealDamage(int Amount)
    {
        // If I use a += here, I can reuse this function to Heal or Damage, just by passing in a positive number to heal, or a negative number to damage.
        health += Amount;
        // Claps the health value so it can never go above 100 or below 0.
        health = Mathf.Clamp(health, 0, 100);

        Debug.Log(gameObject.name + " took " + Amount + " Damage");

        if(health <= 0)
        {
            Debug.Log("Dead");
            dead = true;
            arraysAndListsRecap.RemoveFromAliveList(this);
        }
    }
}
