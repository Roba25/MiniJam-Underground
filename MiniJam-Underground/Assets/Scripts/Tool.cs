using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
Item toolItem;
InventorySystem inventory;
public Sprite icon;

    // Start is called before the first frame update
    void Start()
    {
    inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>();
    toolItem = new Item("Repairs Generator", "Tool", icon);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void OnMouseOver()
    {
    if (Input.GetButtonDown("Fire1") && Vector2.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) < 5)
    {
    if (!inventory.canIncrease)
    {
    Debug.Log("Inventory is full!");
    } else {
    inventory.Add(toolItem);
    Debug.Log("I picked up a tool!");
    Destroy(gameObject);
    }
    }


    }




}
