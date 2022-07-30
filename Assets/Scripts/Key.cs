using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Key : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] AudioManager audioManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audioManager.Play("Key");
            Destroy(this.gameObject);
            gameManager.UnlockChest();
        }
    }
}
