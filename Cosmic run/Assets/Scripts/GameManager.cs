using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    // public CameraRecentre freeLookCamera;
    void Update(){
        if (gameOverUI.activeInHierarchy)
    Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;

    }
    public void gameOver(){
        gameOverUI.SetActive(true);
        //  if (freeLookCamera != null)
        // {
        //     camera.m_RecenterToTargetHeading.m_enabled = false;
        // }
    }
    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Restart");

    }
}