using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatMovement : MonoBehaviour
{
    private float speed = 2f;
    private Rigidbody2D rb;
    public Vector2 Direction;
    
    public bool facingRight = true;
    public bool TurnRat = false;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Direction = new Vector2(2, 0);
        facingRight = true;
    }

    void Update()
    {
        rb.AddForce(Direction * speed);
        Debug.Log("This is running");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Turn")
        {
            Debug.Log("Here");
            if (Direction == new Vector2(2, 0))
            {
                
                Direction = new Vector2(-2, 0);
            }
            else if (Direction == new Vector2(-2, 0))
            {
                Direction = new Vector2(2, 0);
            }
        }
        
        if (collision.transform.tag == "DestroyRat")
        {
            Debug.Log("Restart Level");
        }
    }
}
