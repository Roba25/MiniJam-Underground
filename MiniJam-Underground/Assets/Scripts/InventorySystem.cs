using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    private List<Item> items = new List<Item>();
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Add(Item item)
    {
        items.Add(item);
    }
}
