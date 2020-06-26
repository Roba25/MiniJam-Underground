using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : MonoBehaviour
{
[SerializeField]
GameObject doorToOpen;
[SerializeField]
GameObject player;


    // Start is called before the first frame update
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
