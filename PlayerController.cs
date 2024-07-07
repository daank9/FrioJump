using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;

    private float moveX;

    private float levelWidth = 8;
        
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    


    // Update is called once per frame
    void Update()
    {
        DontExitTheScreen();
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;
    }


    private void DontExitTheScreen()
    {
        if (transform.position.x > levelWidth)
        {
            transform.position -= new Vector3(2 * levelWidth, 0, 0);
        }
        else if (transform.position.x < -levelWidth)
        {
            transform.position += new Vector3(2 * levelWidth, 0, 0);
        }
    }   

    
}
