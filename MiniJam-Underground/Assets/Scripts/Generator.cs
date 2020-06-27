using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
   [HideInInspector]
   public bool isEnabled = false;
   private int toolsUsed = 0;
   GameObject player;
   void Start()
   {
   player = GameObject.FindGameObjectWithTag("Player");
   }

   void ToolUsed()
   {
      toolsUsed++;
      Debug.Log("Repaired: " + toolsUsed + "/3");
      player.GetComponent<InventorySystem>().Remove(Tool.toolItem);
   }

   private void Update()
   {
      if (toolsUsed == 3)
      {
         //Generator is on
         isEnabled = true;
      }
   }
   void OnMouseOver()   
   {
   if (Input.GetButtonDown("Fire1"))
   {
   Debug.Log("Clicked");
   for (int i = 0; i < player.GetComponent<InventorySystem>().items.Count; i++)
   {
   if (player.GetComponent<InventorySystem>().items[i].GetDescription() == "Repairs Generator")
   {
   ToolUsed();
   }   
   }
   }


   }

}
