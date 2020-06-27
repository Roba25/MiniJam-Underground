using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
//  Variables
Rigidbody2D rb2d;
Animator animator;

[SerializeField]
float moveSpeed = 5f;


    void Start()
    {
    rb2d = GetComponent<Rigidbody2D>();
    animator = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
    if (Input.GetKey("d"))
    {
    rb2d.velocity = new Vector2(moveSpeed, rb2d.velocity.y);
    animator.SetFloat("movementX", 1);
    animator.SetFloat("movementY", 0);
    } else if (Input.GetKey("a"))
    {
    rb2d.velocity = new Vector2(-moveSpeed, rb2d.velocity.y);
    animator.SetFloat("movementX", -1);
    animator.SetFloat("movementY", 0);
    } else {
    rb2d.velocity = new Vector2(0, rb2d.velocity.y);
    } 
    if (Input.GetKey("w"))
    {
    rb2d.velocity = new Vector2(rb2d.velocity.x, moveSpeed);
    animator.SetFloat("movementX", 0);
    animator.SetFloat("movementY", 1);
    } else if (Input.GetKey("s"))
    {
    rb2d.velocity = new Vector2(rb2d.velocity.x, -moveSpeed);
    animator.SetFloat("movementX", 0);
    animator.SetFloat("movementY", -1);
    } else {
    rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
    }
    
    }
}
