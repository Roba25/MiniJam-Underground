using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyFragment : MonoBehaviour
{
static Item finalKey;

int fragmentsFound = 0;

Sprite icon;

InventorySystem inventory;

    // Start is called before the first frame update
    void Start()
    {
    inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>();
    }

    // Update is called once per frame
    void Update()
    {
    if (fragmentsFound == 3)
    {
    finalKey = new Item("Opens Final Door", "Final Key", icon);
    inventory.Add(finalKey);
    }        
    }
    public void FindFragment()
    {  
    fragmentsFound++;
    }
}
