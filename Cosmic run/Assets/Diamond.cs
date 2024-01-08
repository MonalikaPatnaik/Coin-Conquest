using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
     public AudioSource coinFX;
     public static int score=0;
    private void OnTriggerEnter(Collider other){
        coinFX.Play();
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory != null){
            playerInventory.DiamondCollected();
            score+=1;
            Destroy(gameObject);
        }
    }
}
