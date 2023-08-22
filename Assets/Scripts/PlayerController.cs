using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables

    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * (Time.deltaTime * speed * horizontalMove));
    }
}
