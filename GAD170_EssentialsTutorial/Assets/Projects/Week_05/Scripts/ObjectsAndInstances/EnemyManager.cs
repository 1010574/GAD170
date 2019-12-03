using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Examples of USING namespaces

// This is a namespace, we can encapsulate our code around it to 
// tell people that this class is contained within a certain namespace grouping our classes together.
namespace Level01
{
    public class EnemyManager : MonoBehaviour
    {
        public Enemy enemy01; // An Instance of Enemy Script
        public Enemy enemy02; // Another Instance of Enemy script

        public EnemyContactDetails enemyDetails; // A data storage class, to contain info about enemy.

        public MainMenu mainMenu; // Another data storage class to contain info about main menu
        public SettingsMenu settingsMenu; // Another data storage class to contain info about settings


        // Start is called before the first frame update
        void Start()
        {

            // this is how I reference my instance of the enemy class and access variables and functions of it. 
            enemy01.SetUpEnemy();
            enemy01.myFirstName = "Poopybutthole";

            // another example of accessing another instance.
            enemy02.SetUpEnemy();
            enemy02.health = 50;
        }
    }

    // System.Serializable lets unity know that I want this visible in the inspector. 
    // this is also an example of a data storage class, where no runtime instance is required to make it work.
    [System.Serializable]
    public class EnemyContactDetails
    {
        public string firstName;
        public string lastName;
        public int age;
    }

    [System.Serializable]
    public class MainMenu
    {
        public Button startButton;

        public void PlayButton()
        {
            Debug.Log("Play The Game");
        }
    }

    [System.Serializable]
    public class SettingsMenu
    {
        public Text settings;
    }
}
