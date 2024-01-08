using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    private TextMeshProUGUI diamondText;
    // public Diamond diamond;
    // public CameraRecentre freeLookCamera;
    void Update()
    {
        if (gameOverUI.activeInHierarchy)
        {
                Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;
            diamondText = GetComponent<TextMeshProUGUI>();
            diamondText.text = Diamond.score.ToString();

        }

    }
    public void gameOver()
    {
        gameOverUI.SetActive(true);
        // freeLookCamera.LockCameraMovement();
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}