using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
public GameObject door;




Generator generator;
bool isPressed = false;



void Start()
{
generator = GameObject.FindGameObjectWithTag("Generator").GetComponent<Generator>();
}




void OnMouseOver()
{
if (Input.GetButtonDown("Fire1"))
{
if (generator.isEnabled)
{
Debug.Log("Seems like it worked, this light turned on.");
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
//  I will hook this up to be said by the player

}


}



}






}