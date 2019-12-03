using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeekTwoGuessingGame : MonoBehaviour
{
    public InputField inputField; // Input field user will interact with
    public Text textField; // Text field to give instructions
    public Text responseField; // Text field to give feedback

    private int m_numberToGuess; // number we are trying to guess
    public int numberGuessed; // number user just guess
    
    // Start is called before the first frame update
    void Start()
    {
        m_numberToGuess = 0; // sets default value for number to guess
        numberGuessed = 0;
        textField.text = "Guess a Number and Press Enter!";
        inputField.text = string.Empty; // makes text field blank
        responseField.text = string.Empty; // makes text field blank
        m_numberToGuess = Random.Range(0, 100);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            m_numberToGuess = 0;
            numberGuessed = 0;
            textField.text = "Guess a Number and Press Enter!";
            inputField.text = string.Empty;
            responseField.text = string.Empty;
            // Generates random number to guess
            m_numberToGuess = Random.Range(0, 100);
        }

        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            // sets default guessed number to -1 in case number returned is not an int
            int tempIntForGuess = -1;

            // Attempt to turn string from text field into an Int (i.e, if the text entered in the field is an Int, then continue, otherwise text saying numbers only).
            if(int.TryParse(inputField.text, out tempIntForGuess))
            {
                numberGuessed = tempIntForGuess;

                // if guess is correct, then win text.
                if (numberGuessed == m_numberToGuess)
                {
                    responseField.color = Color.green;
                    responseField.text = "Ha. You guessed the Number. Good work I guess..";
                }

                // if guess is within +/- 10 of the number to guess, then say so.
                else if (numberGuessed >= m_numberToGuess - 10 && numberGuessed < m_numberToGuess || numberGuessed <= m_numberToGuess + 10 && numberGuessed > m_numberToGuess)
                {
                    responseField.color = Color.yellow;
                    responseField.text = "You may or may not be within 10 numbers...";
                }

                // if guess is not within +/- 10 of the number to guess, then fail text.
                else
                {
                    responseField.color = Color.red;
                    responseField.text = "You're not very good at this. Try again... or give up..";
                }
            }
            // If text entered was not numbers, then text saying numbers only
            else
            {
                responseField.color = Color.red;
                responseField.text = "Please Enter Numbers Only!";
            }
        }

    }
}
