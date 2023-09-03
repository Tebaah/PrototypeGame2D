using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Variables
    public GameObject target;

    private Vector3 offset = new Vector3(0, 0, -10);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (target.transform.position.x < 0)
        {
            transform.position = new Vector3(0, transform.position.y, -10);
        }
        else
        {
            transform.position = target.transform.position + offset;    
        }
    }
}
