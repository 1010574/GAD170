using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysAndListsRecap : MonoBehaviour
{
    public People[] myPeopleArray; // an array for all my people
    public List<People> peopleStillAliveList = new List<People>(); // a list of people still alive

    private Coroutine m_AttackRoutine; // a coroutine to hold my attack ienumerator.


    // Start is called before the first frame update
    void Start()
    {
        // Loops through my array of people and sets them up.
       for(int i = 0; i<myPeopleArray.Length; i++)
        {
            myPeopleArray[i].SetUp();
            // adds all people in array to my alive List.
            peopleStillAliveList.Add(myPeopleArray[i]);
        }

       // If there is already a routine running, stop it before running a new instance of it.
       if(m_AttackRoutine != null)
        {
            StopCoroutine(m_AttackRoutine);
        }
       // a way to keep track to my ienumerator or have a reference to it.
       m_AttackRoutine = StartCoroutine(Attack());
    }

    private IEnumerator Attack()
    {
        // while there is still 2 or more people in my alive list, keep going.
        while (peopleStillAliveList.Count > 1)
        {
            // at the start of the while loop, wait 2 seconds.
            yield return new WaitForSeconds(2);

            People person01 = peopleStillAliveList[0]; // accesses first element in list
            People person02 = peopleStillAliveList[peopleStillAliveList.Count - 1]; // Accesses the last element in list

            int coinFlip = Random.Range(0, 2); // 0 = heads, 1 = tails.

            // Randomly decide who attacks first
            if (coinFlip == 0)
            {
                // Access the person who is attacking and tell it who to attack.
                person01.Attack(person02);
                person02.Attack(person01);
            }
            else
            {
                person02.Attack(person01);
                person01.Attack(person02);
            }


            yield return null;
        }
        // if we get to here, then there's only one person left, so debug the winner
        Debug.Log(peopleStillAliveList[0].gameObject.name + " is the Winner!!!");


        yield return null;
    }

    /// <summary>
    /// Removes the person passed in from the PeopleStillAlive List.
    /// </summary>
    /// <param name="PersonToRemove"></param>
    public void RemoveFromAliveList(People PersonToRemove)
    {
        peopleStillAliveList.Remove(PersonToRemove);
    }
}
