using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public static class InventorySystem : MonoBehaviour
{
    private static List<Item> items = new List<Item>();
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public static void Add(Item item)
    {
        items.Add(item);
    }
    
    
}
