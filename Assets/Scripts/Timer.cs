
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timeSpent = 0;
    private bool timerIsRunning = false;
    [SerializeField] private TextMeshProUGUI timeText;

    [SerializeField] GameManager gameManager;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;;
    }

    void Update()
    {
        if (gameManager.IsGameOver())
        {
            timerIsRunning = false;
        }

        if (timerIsRunning)
        {
            timeSpent += Time.deltaTime;
            DisplayTime(timeSpent, timeText);
        }
    }

    public void DisplayTime(float timeToDisplay, TextMeshProUGUI timeText)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    } 

    public float GetTimeSpent()
    {
        return timeSpent;
    }
}