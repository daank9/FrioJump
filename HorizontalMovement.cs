using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : Character
{
    private float horizontalInput;
    
    
   

    protected override void Initialization()
    {
        base.Initialization();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            horizontalInput = Input.GetAxis("Horizontal");
        }
        else
        {
            horizontalInput = 0;
        }
    
    }
    
    
    private void FixedUpdate()
    {
        if(horizontalInput > 0 && character.isFacingLeft)
        {
            character.isFacingLeft = false;
            Flip();
        }
        if(horizontalInput < 0 && !character.isFacingLeft)
        {
            character.isFacingLeft = true;
            Flip();
        }
    }
}
