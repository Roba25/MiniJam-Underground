using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
//  Variables
Rigidbody2D rb2d;

[SerializeField]
float moveSpeed = 5f;


    void Start()
    {
    rb2d = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
    if (Input.GetKey("d"))
    {
    rb2d.velocity = new Vector2(moveSpeed, rb2d.velocity.y);
    } else if (Input.GetKey("a"))
    {
    rb2d.velocity = new Vector2(-moveSpeed, rb2d.velocity.y);
    } else {
    rb2d.velocity = new Vector2(0, rb2d.velocity.y);
    } 
    if (Input.GetKey("w"))
    {
    rb2d.velocity = new Vector2(rb2d.velocity.x, moveSpeed);
    } else if (Input.GetKey("s"))
    {
    rb2d.velocity = new Vector2(rb2d.velocity.x, -moveSpeed);
    } else {
    rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
    }
    
    }
}
