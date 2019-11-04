using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoffeeMachineV2 : MonoBehaviour
{
    #region VARIABLES
    // A enum is like a list of strings that we can select
    // Designer friendly, check your editor!
    // Access Type, Followed by keyword "ENUM"
    // then give your enum a name, followed by {enum choices}
    // then you need to declare a variable using a enum type

    //Enum for coffee choices
    public enum CoffeeType {None, Cappuchino, FlatWhite, LongBlack};
    public CoffeeType myCoffeeChoice;

    //Enum for changing order stages
    public enum OrderStatus {Welcome, SelectCoffee, WaitingForInput, AskMilk, SelectMilk, AskForSugar, SugarSelected, OrderComplete};
    public OrderStatus currentOrderStatus;

    //Enum for milk types
    public enum MilkType {NoMilk, FullCream, LightMilk};
    public MilkType currentMilkChoice;

    //Enum for sugar amounts
    public enum AmountOfSugar {Zero, One, Two, Three}
    public AmountOfSugar sugarAmount;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        ResetCoffeeMachine();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ResetCoffeeMachine();
        }

        if(currentOrderStatus == OrderStatus.WaitingForInput)
        {
            return;
        }

        if (currentOrderStatus == OrderStatus.Welcome)
        {
            StartCoffeeMachine();
        }
        else if (currentOrderStatus == OrderStatus.SelectCoffee)
        {
            DetermineCoffeeOrder();
        }
        else if (currentOrderStatus == OrderStatus.AskMilk)
        {
            AskForMilk();
        }
        else if (currentOrderStatus == OrderStatus.SelectMilk)
        {
            DetermineMilkChoice();
        }
        else if (currentOrderStatus == OrderStatus.AskForSugar)
        {
            AskForSugars();
        }
        else if (currentOrderStatus == OrderStatus.SugarSelected)
        {
            DetermineSugarAmount();
        }
        else if (currentOrderStatus == OrderStatus.OrderComplete)
        {
            CoffeeOrderCompleted();
        }
    }
    /// <summary>
    /// Displays welcome message for Cafe, and asks for type of coffee
    /// </summary>
    private void StartCoffeeMachine()
    {
        Debug.Log("Welcome to the Dodgy AF Cafe. Don't ask us where our coffee comes from..");
        Debug.Log("What kind of coffee would you like? \n 1: Cappuchino \n 2: Flat White \n 3: Long Black");
        currentOrderStatus = OrderStatus.SelectCoffee;
        
    }
    /// <summary>
    /// Determines coffee selection via user input.
    /// </summary>
    private void DetermineCoffeeOrder()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            CoffeeSelection(CoffeeType.Cappuchino);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            CoffeeSelection(CoffeeType.FlatWhite);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            myCoffeeChoice = CoffeeType.LongBlack;
            currentOrderStatus = OrderStatus.SelectMilk;            
        }

        if (myCoffeeChoice == CoffeeType.None)
        {
            return;
        }
    }    
    /// <summary>
    /// Takes in Coffee Choice and sets to that. Then progresses to asking milk
    /// </summary>
    /// <param name="CurrentChoice"></param>
    private void CoffeeSelection(CoffeeType CurrentChoice)
    {
        if (CurrentChoice == CoffeeType.None)
        {
            return;
        }
        myCoffeeChoice = CurrentChoice;
        currentOrderStatus = OrderStatus.AskMilk;
    }
    /// <summary>
    /// Asks what milk user wants
    /// </summary>
    private void AskForMilk()
    {
        Debug.Log("What kind of milk would you like? \n 1: Full Cream \n 2: Light Milk");
        currentOrderStatus = OrderStatus.SelectMilk;
    }
    /// <summary>
    /// Determines users milk choice via user input
    /// </summary>
    private void DetermineMilkChoice()
    {
        if(myCoffeeChoice == CoffeeType.LongBlack)
        {
            Debug.Log("Long Black Selected - No Milk Required");
            MilkSelection(MilkType.NoMilk);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
            {
                // Selected full cream milk
                MilkSelection(MilkType.FullCream);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
            {
                // Selected Light Milk
                MilkSelection(MilkType.LightMilk);
            }
        }
        
    }
    /// <summary>
    /// Takes in a milk choice and then sets it to that. Then progresses order to sugar.
    /// </summary>
    /// <param name="CurrentChoice"></param>
    private void MilkSelection(MilkType CurrentChoice)
    {
        currentMilkChoice = CurrentChoice;
        Debug.Log(currentMilkChoice.ToString() + " Selected");
        currentOrderStatus = OrderStatus.AskForSugar;
    }
    /// <summary>
    /// Resets Coffee Machine
    /// </summary>
    private void ResetCoffeeMachine()
    {
        myCoffeeChoice = CoffeeType.None;
        currentOrderStatus = OrderStatus.Welcome;
        sugarAmount = AmountOfSugar.Zero;
    }

    /// <summary>
    /// Ask the user how many sugars they want
    /// </summary>
    private void AskForSugars()
    {
        Debug.Log("How many sugars would you like? \n 1: 1 \n 2: 2 \n 3: 3");
        currentOrderStatus = OrderStatus.SugarSelected;
    }
    /// <summary>
    /// Determines amount of sugar by user input
    /// </summary>
    private void DetermineSugarAmount()
    {


        if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            // One sugar selected
            PutSugarIn(AmountOfSugar.One);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            // Two sugars selected
            PutSugarIn(AmountOfSugar.Two);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            // Three sugars selected
            PutSugarIn(AmountOfSugar.Three);
        }

        if(sugarAmount == AmountOfSugar.Zero)
        {
            return;
        }
    }
    private void PutSugarIn(AmountOfSugar Sugars)
    {
        sugarAmount = Sugars;
        currentOrderStatus = OrderStatus.OrderComplete;
        Debug.Log(sugarAmount.ToString() + " Selected");
    }

    /// <summary>
    /// Coffee Order is now complete!
    /// </summary>
    private void CoffeeOrderCompleted()
    {
        Debug.Log("Here is your coffee, choke on it.");
        currentOrderStatus = OrderStatus.WaitingForInput;
    }
}
