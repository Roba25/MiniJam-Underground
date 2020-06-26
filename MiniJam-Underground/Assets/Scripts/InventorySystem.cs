﻿using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    private List<Item> items = new List<Item>();
    public Image[] slots;
    private int numOfItems = 0;

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
        
        slots[numOfItems].GetComponent<Image>().sprite = items[numOfItems].GetIcon();
       
        if (slots[numOfItems].sprite == items[numOfItems].GetIcon())
        {
        Debug.Log("Working");
        }

        numOfItems++;

    }
}
