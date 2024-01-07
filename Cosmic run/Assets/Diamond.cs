using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
     public AudioSource coinFX;
    private void OnTriggerEnter(Collider other){
        coinFX.Play();
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory != null){
            playerInventory.DiamondCollected();
            // gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
