using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorKey : MonoBehaviour
{
[SerializeField]
GameObject doorToOpen;
[SerializeField]
GameObject player;
static Item key;
public Sprite icon;
public float maxRange;

DialogueManager dialogueManager;

    // Start is called before the first frame update
    

    void Start()
    {
    dialogueManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<DialogueManager>();
    key = new Item("Opens Door", "DoorKey", icon);
    player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {   
    if (Input.GetButtonDown("Fire1") && Vector2.Distance(transform.position, player.transform.position) < maxRange)
    {
    if (player.GetComponent<InventorySystem>().canIncrease)
    {
    player.GetComponent<InventorySystem>().Add(key);
    Debug.Log("I picked up a key!");
    dialogueManager.TriggerDialogue("You picked up a key!");
    Destroy(gameObject);
    } else {
    Debug.Log("My inventory is full!");
    dialogueManager.TriggerDialogue("Your inventory is full!");
    }
}
}
}
