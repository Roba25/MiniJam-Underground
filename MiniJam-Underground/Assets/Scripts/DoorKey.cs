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
Item key;
public Sprite icon;

    // Start is called before the first frame update
    

    void Start()
    {
    key = new Item("Opens Door", "DoorKey", icon);
    player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {   
    if (Input.GetButtonDown("Fire1"))
    {
    player.GetComponent<InventorySystem>().Add(key);
    
    
    }
    }
}
