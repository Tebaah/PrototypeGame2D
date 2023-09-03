using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Variables
    public GameObject target;
    private float zRange = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (target.transform.position.x < 0)
        {
            transform.position = new Vector3(0, transform.position.y, zRange);
        }
        else
        {
            transform.position = new Vector3(target.transform.position.x, 2.5f, zRange);    
        }
    }
}
