using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
            gameManager.AddCoin();
        }
    }
}
