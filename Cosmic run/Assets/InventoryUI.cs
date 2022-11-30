using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI diamondText;
    private TextMeshProUGUI diamondEndText;
    // Start is called before the first frame update
    void Start()
    {
        diamondText = GetComponent<TextMeshProUGUI>();
        diamondEndText = GetComponent<TextMeshProUGUI>();
    }

   public void UpdateDiamondText(PlayerInventory playerInventory){
       diamondText.text = playerInventory.NumberOfDiamonds.ToString();
       diamondEndText.text = playerInventory.NumberOfDiamonds.ToString();  
   }
}
