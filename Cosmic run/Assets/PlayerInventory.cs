using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
   public int NumberOfDiamonds { get; private set; }

   public UnityEvent<PlayerInventory> OnDiamondCollected;

   public void DiamondCollected(){
      NumberOfDiamonds++;
      OnDiamondCollected.Invoke(this);
   }
}
