using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitBowl : MonoBehaviour
{

    public KeyCode chopFruitButton = KeyCode.Mouse0;

    public Banana firstBanana; // reference to my banana instance
    public Apple firstApple; // reference to my apple instance
    public PurpleGrape firstGrape; // reference to my grape instance

    // Start is called before the first frame update
    void Start()
    {
        firstBanana.SetUpFruit();
        firstApple.SetUpFruit();
        firstGrape.SetUpFruit();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(chopFruitButton))
        {
            firstBanana.ChopFruit();
            firstGrape.ChopFruit();
            firstApple.ChopFruit();
        }
    }
}
