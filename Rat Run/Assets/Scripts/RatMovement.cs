using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatMovement : MonoBehaviour
{
    public float maxSpeed = 3f;
    private float speed = 2f;
    private Rigidbody2D rb;
    public Vector2 Direction;
    
    public bool facingRight = true;
    public bool TurnRat = false;

    public Transform wallCheckPoint;
    public float wallCheckRadius;
    public LayerMask whatIsWall;

    public bool CheckWall = false;

    public GameObject WonScreen;
    public GameObject LostScreen;
    public GameObject Instructions1;
    public GameObject Instructions2;
    public GameObject Instructions3;

    private Vector3 checkpointPosition;
    public bool hasReachedCheckPoint = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Direction = new Vector2(2, 0);
        facingRight = true;
        Time.timeScale = 1f;
    }

    void Update()
    {
        CheckWall = Physics2D.OverlapCircle(wallCheckPoint.position, wallCheckRadius, whatIsWall);

        if (CheckWall == true)
        {
            rb.AddForce(Direction * speed);
            Debug.Log("This is running");

            if (rb.velocity.magnitude > maxSpeed)
            {
                rb.velocity = rb.velocity.normalized * maxSpeed;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        { 
            Application.Quit();
        }
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
            if (hasReachedCheckPoint != true)
            {
                LostScreen.SetActive(true);
                Time.timeScale = 0f;
            }
            
            if (hasReachedCheckPoint == true)
            {
                this.transform.position = this.checkpointPosition;
            }
        }

        if (collision.transform.tag == "Exit")
        {
            Debug.Log("Restart Level");
            WonScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Vents vents = GameObject.FindWithTag("Vent").GetComponent<Vents>();

        if (col.gameObject.tag == "Hitbox1")
        {
            maxSpeed = 0;
            Instructions1.SetActive(true);
            
            vents.canClick = true;
        }
        if (col.gameObject.tag == "Hitbox2")
        {
            maxSpeed = 0;
            Instructions2.SetActive(true);

            vents.canClick = true;
        }
        if (col.gameObject.tag == "Hitbox3")
        {
            maxSpeed = 0;
            Instructions3.SetActive(true);

            vents.canClick = true;
        }

        if (col.gameObject.tag == "Checkpoint1") //Only in third level (Level 2)
        {
            Debug.Log("Checkpoint 1 set");
            hasReachedCheckPoint = true;
            this.checkpointPosition = this.transform.position;
        }

        if (col.gameObject.tag == "EndCheckpoint1") //Only in third level (Level 2)
        {
            Debug.Log("Checkpoint 1 end");
            hasReachedCheckPoint = false;
        }
    }
}
