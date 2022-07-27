using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int coins;
    [SerializeField] TextMeshProUGUI coinText;

    public void AddCoin()
    {
        coins += 1;
        coinText.text = "" + coins;
    }
}
