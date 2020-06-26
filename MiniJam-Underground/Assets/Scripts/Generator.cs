using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
   private int toolsUsed = 0;
   GameObject player;
   void Start()
   {
   player = GameObject.FindGameObjectWithTag("Player");
   }

   void ToolUsed()
   {
      toolsUsed++;
      
   }

   private void Update()
   {
      if (toolsUsed == 3)
      {
         //Generator is on
      }
   }
   void OnMouseOver()   
   {
   if (Input.GetButtonDown("Fire1"))
   {
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
