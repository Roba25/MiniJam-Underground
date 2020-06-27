using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
Generator generator;

void OnMouseOver()
{
if (Input.GetButtonDown("Fire1"))
{
if (generator.isEnabled)
{
Debug.Log("Seems like it worked, this light turned on.");
//  Proceed to next step



} else {
Debug.Log("You pushed the button but nothing happened.");
//  I will hook this up to be said by the player

}


}



}






}