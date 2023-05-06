using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlaeyr : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public float jump;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

  
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        
        if (Input.GetKey(KeyCode.D))
        
        {
            rb.velocity = new Vector2(speed, 0);
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, jump);
        }
    }
}
