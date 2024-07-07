using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : Character
{

     private float verticalInput;
    public SpriteRenderer spriteRenderer;
    public Sprite Sprite1;
    public Sprite Sprite2;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = rb.velocity;
        rb.velocity = velocity;
       if(velocity.y != 0)
        {
            verticalInput = velocity.y;
        }
        else
        {
            verticalInput = 0;
        } 
    }
    private void FixedUpdate()
    {
        if(verticalInput > 0){
            spriteRenderer.sprite = Sprite2;
        }
        if(verticalInput < 0){
            spriteRenderer.sprite = Sprite1;
        }
    }
}
