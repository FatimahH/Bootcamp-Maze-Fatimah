using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int coins;
    private bool chestLocked = true;
    private bool isGameOver = false;

    [SerializeField] TextMeshProUGUI coinText;
    [SerializeField] TextMeshProUGUI collectedCoinText;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] AudioManager audioManager;
    [SerializeField] AudioSource backgroundMusic;
    [SerializeField] Timer timer;
    [SerializeField] GameObject instructionsText;
    [SerializeField] GameObject winPanel;

    private void Start()
    {
        Invoke("HideInstructions", 5.0f);
    }

    public void AddCoin()
    {
        coins += 1;
        coinText.text = "" + coins;
    }

    public void UnlockChest()
    {
        chestLocked = false;
    }

    public bool IsChestLocked()
    {
        return chestLocked;
    }

    public void GameOver()
    {
        Debug.Log("Player won!");
        isGameOver = true;
        backgroundMusic.Stop();
        audioManager.Play("Win");
        ShowWinPanel();
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }

    private void HideInstructions()
    {
        instructionsText.SetActive(false);
    }

    private void ShowWinPanel()
    {
        winPanel.SetActive(true);
        collectedCoinText.text = coinText.text;
        timer.DisplayTime(timer.GetTimeSpent(), timerText);

    }
}
