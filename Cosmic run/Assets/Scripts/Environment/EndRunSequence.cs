// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using TMPro;
// public class EndRunSequence : MonoBehaviour
// {
// //     public GameObject liveDiamonds;
// //     public GameObject endScreen;
// //     public GameObject fadeOut;
// //     // Start is called before the first frame update
// //     void Start()
// //     {
// //         StartCoroutine(EndSequence());
// //     }

// //     IEnumerator EndSequence()
// //     {
// //         yield return new WaitForSeconds(5);
// //         liveDiamonds.SetActive(false);
// //         endScreen.SetActive(false);
// //         yield return new WaitForSeconds(5);
// //         fadeOut.SetActive(true);

// //     }
// private TextMeshProUGUI diamondText;
//  private PlayerInventory playerInventory;
//  void Start()
//     {
//         // Disable the end screen UI at the start
//         gameObject.SetActive(false);
//     }

//     // Function to display the final score on the end screen
//     public void DisplayFinalScore()
//     {
//         // Enable the end screen UI
//         gameObject.SetActive(true);
//   int finalScore = playerInventory.GetFinalScore();
//         // Update the score text
//         diamondText.text = "Final Score: " + finalScore.ToString();
//     }
// }
