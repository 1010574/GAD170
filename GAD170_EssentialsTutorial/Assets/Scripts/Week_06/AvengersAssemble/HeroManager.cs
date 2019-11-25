using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class HeroManager : MonoBehaviour
{
    public List<Hero> allHeroes = new List<Hero>(); // list of all our heroes
    public List<Hero> heroesLeft = new List<Hero>(); // List of current heores left.
    public List<Hero> heroesRemoved = new List<Hero>(); // List of heroes removed from game.
    public Thanos thanos; // reference to Thanos script.

    private Coroutine m_GameRoutine; // a reference to out coroutine that store our Ienumerator.

    // Start is called before the first frame update
    void Start()
    {
        // Finds an array of all the heroes in my scene, and converts it to a list.
        allHeroes = FindObjectsOfType<Hero>().ToList();
        // Create a copy of the all heroes list.
        heroesLeft = FindObjectsOfType<Hero>().ToList();
        // a reference to our Thanos script
        thanos = FindObjectOfType<Thanos>();

        // An example of using a couroutine
        if(m_GameRoutine != null)
        {
            StopCoroutine(m_GameRoutine);
        }
        m_GameRoutine = StartCoroutine(GameTurns());
    }

    private IEnumerator GameTurns()
    {
        // While this condition is true, keep doing these actions. 
        while(thanos.health > 0 && heroesLeft.Count > 0)
        {
            // Go through each hero that is left and deal some damage to thanos
            for(int i =0; i<heroesLeft.Count; i++)
            {
                thanos.DealDamage(-heroesLeft[i].weaponDamage);
            }

            if(thanos.health > 0)
            {
                //Thanos still alive
                RemoveHalf();
            }
            else
            {
                Debug.Log("Thanos is dead");
            }

            yield return new WaitForSeconds(2);
            if (CoinFlip())
            {
                // If heads, respawn hero.
                RespawnHero();
            }

            yield return null;
        }
    }

    /// <summary>
    /// Simple coin flip to see if someone comes back.
    /// </summary>
    /// <returns></returns>
    private bool CoinFlip()
    {
        int flip = Random.Range(0, 2);

        if (flip > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Kills off half the Avengers
    /// </summary>
    private void RemoveHalf()
    {
        if(heroesLeft.Count <= 1)
        {
            Debug.Log("Thanos has Won :(");
            heroesLeft.Clear();
        }
        else
        {
            // go through our list of heroes, and if I is divisible by 2, delete them.
            for(int i=0; i<heroesLeft.Count; i++)
            {
                // if "i" is even, delete hero
                if(i %2 == 0)
                {
                    heroesRemoved.Add(heroesLeft[i]);
                }
            }
            DespawnHero();
        }
    }

    public void RespawnHero()
    {
        Hero randomHero = heroesRemoved[Random.Range(0, heroesRemoved.Count)];

        // Takes them out of the Heroes Removed pool.
        for(int i=0; i<heroesRemoved.Count; i++)
        {
            if(heroesRemoved[i] == randomHero)
            {
                heroesRemoved.RemoveAt(i);
                i--;
            }
        }

        // Adds the hero back into existence. 
        heroesLeft.Add(randomHero);
        Debug.Log("Respawned" + randomHero.heroName);
    }

    public void DespawnHero()
    {
        // Here we are going through our heroes left and checking if they are in the heroes removed list
        // if they are, remove them from the active list.
        for(int i=0; i<heroesLeft.Count; i++)
        {
            for(int j=0; j<heroesRemoved.Count; j++)
            {
                if (heroesLeft[i] == heroesRemoved[j])
                {
                    Debug.Log("Despawned" + heroesLeft[i].heroName);
                    heroesLeft.RemoveAt(i);                    
                    i--;
                    // break can be used to break out of a For loop.
                    break;
                }
            }
        }
       
        Debug.Log("Thanos snapped his fingers, there are now" + heroesLeft.Count + "/ " + allHeroes.Count);


    }
}
