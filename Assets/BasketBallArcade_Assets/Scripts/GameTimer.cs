using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{

    public float gameDuration;
    public TextMeshPro timerText;
    public GameObject stopper;

    // Start is called before the first frame update
    void Start()
    {
        // Set timer text to game duration
        timerText.text = ((int)gameDuration).ToString();

        // Lower stopper
        stopper.GetComponent<Transform>().position = new Vector3(0.03f, 0.5f, 2.7f);
    }

    // Update is called once per frame
    void Update()
    {
        // Update UI Timer
        gameDuration -= Time.deltaTime; // subtract time since script started running
        timerText.text = ((int)gameDuration).ToString();


        // If Timer is done end the game
        if (gameDuration < 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        // Set stopper back to regular position
        stopper.GetComponent<Transform>().position = new Vector3(0.03f, 1.2f, 2.7f);
        timerText.text = "Game Over!";

    }
}
