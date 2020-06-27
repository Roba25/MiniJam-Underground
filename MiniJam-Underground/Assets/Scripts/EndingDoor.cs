using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingDoor : MonoBehaviour
{
InventorySystem inventory;
DialogueManager dialogueManager;

    private void Start()
    {
    dialogueManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<DialogueManager>();
    inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>();
    }
    void OnMouseOver()
    {
    Debug.Log("Mouse over");
    if (Input.GetButtonDown("Fire1"))
    {
    Debug.Log("Clicked");
    for (int i = 0; i < inventory.items.Count; i++)
    {
    if (inventory.items[i].GetDescription() == "Opens Final Door")
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    Debug.Log("You have a key!");
    } else {
    dialogueManager.TriggerDialogue("The door is locked with a key!");
    }
    }






    }
    }




}
