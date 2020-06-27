using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

Vector3 pos;

Transform player;

public float minX;
public float maxX;
public float minY;
public float maxY;


    // Start is called before the first frame update
    void Start()
    {
    player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
    pos = new Vector3(
    player.position.x,
    player.position.y,
    -20);
    pos.x = Mathf.Clamp(transform.position.x, minX, maxX);
    pos.y = Mathf.Clamp(transform.position.y, minY, maxY);
    transform.position = pos;
    }
}
