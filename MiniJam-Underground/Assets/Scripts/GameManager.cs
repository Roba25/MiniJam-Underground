using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
public int fragmentsFound;
public int codePeicesFound;
Item finalKey;
Item finalCode;
public Sprite icon;
public Sprite codeIcon;
InventorySystem inventory;
DialogueManager dialogueManager;

    private void Start() 
    {
    DontDestroyOnLoad(gameObject);
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
    if (codePeicesFound == 2)
    {
    finalCode = new Item("Has the code!", "Final Code", codeIcon);
    inventory.Remove(CodePaper.codePeice);
    inventory.Add(finalCode);
    dialogueManager.TriggerDialogue("The code!");
    codePeicesFound = 0;
    }
    }








}