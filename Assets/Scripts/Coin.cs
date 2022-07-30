using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] AudioManager audioManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audioManager.Play("Coin");
            Destroy(this.gameObject);
            gameManager.AddCoin();
        }
    }
}
