using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] Animator chestAnimator;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && !gameManager.IsChestLocked())
        {
            OpenChest();
            gameManager.GameOver();
        }
    }

    private void OpenChest()
    {
        chestAnimator.SetBool("Open", true);
    }

}
