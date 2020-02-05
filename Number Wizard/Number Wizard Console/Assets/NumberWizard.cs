using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NewGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NewGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Correct number was found! A new game will be started!");
            StartGame();
        }
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number, but don't tell me what it is...");
        Debug.Log("The highest number you can pick is " + max + ".");
        Debug.Log("The lowest number you can pick is " + min + ".");
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct number");
        max = max + 1;
    }

    void NewGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is your number higher or lower than " + guess);
    }
}
