using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject textState;

    public PlayerController playerState;
    // Start is called before the first frame update
    void Start()
    {
        playerState = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerState.isAlive)
        { 
            textState.SetActive(true);
        }
    }
}
