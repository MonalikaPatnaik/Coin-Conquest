using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject thePlayer;
    public GameObject charModel;
    // public GameObject levelControl;
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = thePlayer.GetComponent<PlayerMovement>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
gameManager.gameOver();
        // levelControl.GetComponent<EndRunSequence>().DisplayFinalScore();
    }
}
