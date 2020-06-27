using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
public int fragmentsFound;
Item finalKey;
public Sprite icon;
InventorySystem inventory;
DialogueManager dialogueManager;

    private void Start() 
    {
    inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>();
    dialogueManager = GetComponent<DialogueManager>();
    }

    private void Update() 
    {
    if (fragmentsFound == 3)
    {
     finalKey = new Item("Opens Final Door", "Final Key", icon);
    inventory.Remove(KeyFragment.fragment);
    inventory.Add(finalKey);
    dialogueManager.TriggerDialogue("The fragments formed a key!");
    fragmentsFound = 0;
    }    
    }








}