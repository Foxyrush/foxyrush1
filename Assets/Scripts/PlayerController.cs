using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 3.5f;
    public Rigidbody2D RB;


    void Start()
    {
        
    }

    
    void Update()
    {
        RB.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), RB.velocity.y); 
    }
}
