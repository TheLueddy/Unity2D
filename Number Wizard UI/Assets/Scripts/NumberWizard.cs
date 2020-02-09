using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    [SerializeField]int max;
    [SerializeField]int min;
    [SerializeField] Text guessText;


    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    public void OnPressHigher()
    {
        min = guess;
        NewGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        NewGuess();
    }

    void StartGame()
    {
        NewGuess();
        max = max + 1;
    }

    void NewGuess()
    {
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }
}
