using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyFragment : MonoBehaviour
{
static Item finalKey;
static Item fragment;

int fragmentsFound = 0;

public Sprite icon;
public Sprite fragmentIcon;

InventorySystem inventory;
DialogueManager dialogueManager;

    // Start is called before the first frame update
    void Start()
    {
    inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>();
    dialogueManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
    if (fragmentsFound == 3)
    {
    finalKey = new Item("Opens Final Door", "Final Key", icon);
    inventory.Remove(fragment);
    inventory.Add(finalKey);
    dialogueManager.TriggerDialogue("The fragments formed a key!");
    }        
    }
    public void FindFragment()
    {  
    fragmentsFound++;
    fragment = new Item("Fragment for Final Door", "Key Fragment", fragmentIcon);
    inventory.Add(fragment);
    dialogueManager.TriggerDialogue("You found a key fragment!");
    Destroy(gameObject);
    }
    void OnMouseOver()
    {
    if (Input.GetButtonDown("Fire1"))
    {
    FindFragment();   



    }
    }
}
