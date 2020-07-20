using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 100;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {


        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number");
        Debug.Log("Lowest number is: "+ min);
        Debug.Log("highest number is: "+ max);


        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = higher; Push Down= Lower, Push enter = Correct ");
        max += 1;

    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is your number higher or lower than " + guess +"?");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("DownArrow key was pressed.");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is your number higher or lower than " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Return key was pressed.");
        }

    }
}
