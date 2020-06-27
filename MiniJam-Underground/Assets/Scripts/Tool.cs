using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
public static Item toolItem;
InventorySystem inventory;
public Sprite icon;
DialogueManager dialogueManager;

    // Start is called before the first frame update
    void Start()
    {
    dialogueManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<DialogueManager>();
    inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>();
    toolItem = new Item("Repairs Generator", "Tool", icon);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void OnMouseOver()
    {
    if (Input.GetButtonDown("Fire1") && Vector2.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) < 0.5)
    {
    if (!inventory.canIncrease)
    {
    Debug.Log("Inventory is full!");
    dialogueManager.TriggerDialogue("Your inventory is full!");
    } else {
    inventory.Add(toolItem);
    Debug.Log("I picked up a tool!");
    dialogueManager.TriggerDialogue("You picked up a tool!");
    Destroy(gameObject);
    }
    }


    }




}
