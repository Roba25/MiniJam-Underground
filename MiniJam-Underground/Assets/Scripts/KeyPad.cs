using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : MonoBehaviour
{
DialogueManager dialogueManager;
InventorySystem inventory;
    
    void Start()
    {
    inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>();
    dialogueManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<DialogueManager>();
    }



    void OnMouseOver()
    {
    if (Input.GetButtonDown("Fire1") && Vector2.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) < 5)
    {
    for (int i = 0; i < inventory.items.Count; i++)
    {
    if (inventory.items[i].GetDescription() == ("Has the code!"))
    {
    dialogueManager.TriggerDialogue("The code worked!");
    gameObject.SetActive(false);
    } else {
    dialogueManager.TriggerDialogue("I don't know the code.... I'll have to figure it out if I want to get in..");
    }
    }




    }
    }







}