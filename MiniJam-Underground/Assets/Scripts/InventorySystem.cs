using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    [HideInInspector]
    public List<Item> items = new List<Item>();
    public Image[] slots;
    private int numOfItems = 0;

    public bool canIncrease = true;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
    if (numOfItems == slots.Length)
    {
    canIncrease = false;
    }
    }


    public void Add(Item item)
    {
        items.Add(item);
        
        slots[numOfItems].GetComponent<Image>().sprite = items[numOfItems].GetIcon();
       
        if (slots[numOfItems].sprite == items[numOfItems].GetIcon())
        {
        Debug.Log("Working");
        }
        if (canIncrease)
        {
        numOfItems++;
        }

    }
    public void Remove(Item item)
    {
        items.Remove(item);
        for (int i = 0; i < slots.Length; i++)
        {
        if (slots[i].GetComponent<Image>().sprite == item.GetIcon())
        {
        slots[i].GetComponent<Image>().sprite = null;
        numOfItems--;
        }

        }



        }

    }

