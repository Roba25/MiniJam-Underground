using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyFragment : MonoBehaviour
{
static Item finalKey;
public static Item fragment;

int fragmentsFound = 0;

public Sprite icon;
public Sprite fragmentIcon;

InventorySystem inventory;
DialogueManager dialogueManager;
GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
    gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>();
    dialogueManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<DialogueManager>();
    }

       
    
    public void FindFragment()
    {  
    gameManager.fragmentsFound++;
    fragment = new Item("Fragment for Final Door", "Key Fragment", fragmentIcon);
    inventory.Add(fragment);
    dialogueManager.TriggerDialogue("You found a key fragment!");
    Destroy(gameObject);
    }
    void OnMouseOver()
    {
    if (Input.GetButtonDown("Fire1") && Vector2.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) < 5)
    {
    FindFragment();   
    }
    }
}
