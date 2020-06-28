using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodePaper : MonoBehaviour
{
InventorySystem inventory;
GameManager gameManager;
public static Item codePeice;
public Sprite icon;

    void Start()
    {
    inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>();
    gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    codePeice = new Item("Peice of the code!", "Code Peice", icon);
    }
    void OnMouseOver()
    {
    if (Input.GetButtonDown("Fire1") && Vector2.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) < 5)
    {
    Debug.Log("Clicked");
    inventory.Add(codePeice);
    gameManager.codePeicesFound++;
    Destroy(gameObject);
    }
    }




}