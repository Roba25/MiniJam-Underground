using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
Generator generator;
bool isPressed = false;

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
//  Open 1 door but close the other.
} else {
isPressed = false;
//  Do the same thing but opposite doors.
}
} else {
Debug.Log("You pushed the button but nothing happened.");
//  I will hook this up to be said by the player

}


}



}






}