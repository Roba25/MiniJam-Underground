using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : Item
{
[SerializeField]
GameObject doorToOpen;
[SerializeField]
GameObject player;


    // Start is called before the first frame update
    public DoorKey(string description, string title, Sprite icon, GameObject doorToOpen, GameObject player) : base(description, title, icon)
    {
        this.doorToOpen = doorToOpen;
        this.player = player;
    }

    void Start()
    {
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
    
    Destroy(gameObject);
    
    }
    }
}
