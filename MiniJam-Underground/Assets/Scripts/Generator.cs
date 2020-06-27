using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Generator : MonoBehaviour
{
   [HideInInspector]
   public bool isEnabled = false;
   private int toolsUsed = 0;
   
   GameObject player;

   DialogueManager dialogueManager;
   void Start()
   {
   dialogueManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<DialogueManager>();
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
   dialogueManager.TriggerDialogue("Repaired: " + toolsUsed.ToString() + "/3");
   }  
   }
   }
   }
}
