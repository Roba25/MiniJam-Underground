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
public float maxRange;
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
    if (Input.GetButtonDown("Fire1") && Vector2.Distance(transform.position, player.transform.position) < maxRange)
    {
    if (player.GetComponent<InventorySystem>().canIncrease)
    {
    player.GetComponent<InventorySystem>().Add(key);
    Debug.Log("I picked up a key!");
    Destroy(gameObject);
    } else {
    Debug.Log("My inventory is full!");
    }
}
}
}
