using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
public GameObject door;
bool isPressed = false;



DialogueManager dialogueManager;
Generator generator;



void Start()
{
generator = GameObject.FindGameObjectWithTag("Generator").GetComponent<Generator>();
dialogueManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<DialogueManager>();
}




void OnMouseOver()
{
if (Input.GetButtonDown("Fire1") && Vector2.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) < 5)
{
if (generator.isEnabled)
{
Debug.Log("Seems like it worked, this light turned on.");
dialogueManager.TriggerDialogue("The button worked!");
if (!isPressed)
{
isPressed = true;
door.SetActive(false);
//  Open 1 door but close the other.
} else {
isPressed = false;
door.SetActive(true);
//  Do the same thing but opposite doors.
}
} else {
Debug.Log("You pushed the button but nothing happened.");
dialogueManager.TriggerDialogue("Doesent work, maybe I need to turn on the power?");
//  I will hook this up to be said by the player

}


}



}






}