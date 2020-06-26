using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    private List<Item> items = new List<Item>();
    public Image[] slots;
    

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
    slots[0].GetComponent<Image>().sprite = items[0].GetIcon();
    if (slots[0].sprite == items[0].GetIcon())
    {
    Debug.Log("Working");
    }
    }
}
