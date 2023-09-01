using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
public class PlayerController : MonoBehaviour
{
    // Variables
    private Rigidbody2D rb;
    public int force;
    private bool isGround = true;
    public bool isAlive = true;

    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
        Jump();
        if (transform.position.y < -6f)
        {
            Debug.Log("You are dead");
            isAlive = false;
            Time.timeScale = 0;
        }
    }
    
    void Move()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * (Time.deltaTime * speed * horizontalMove));
    }
    
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rb.AddForce(Vector2.up * force);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log(("You are dead"));
            isAlive = false;
            Time.timeScale = 0;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }
}
