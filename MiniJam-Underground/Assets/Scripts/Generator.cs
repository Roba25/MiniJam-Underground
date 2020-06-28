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
   [SerializeField]
   GameObject light;

   DialogueManager dialogueManager;
   bool hasRemoved;
   void Start()
   {
   dialogueManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<DialogueManager>();
   player = GameObject.FindGameObjectWithTag("Player");
   }

   void ToolUsed()
   {
      if (!hasRemoved)
      {
      toolsUsed++;
      Debug.Log("Repaired: " + toolsUsed + "/3");
      player.GetComponent<InventorySystem>().Remove(Tool.toolItem);      
      dialogueManager.TriggerDialogue("Repaired: " + toolsUsed.ToString() + "/3");
      
      }
      
   }

   private void Update()
   {
      if (toolsUsed == 3)
      {
         light.SetActive(true);
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
   break;
   }  
   }
   }
   }
}
