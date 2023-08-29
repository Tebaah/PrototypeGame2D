using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables
    private Rigidbody2D rb;
    public int force;

    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * (Time.deltaTime * speed * horizontalMove));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }
}
