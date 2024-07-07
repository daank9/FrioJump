using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
   
   protected Character character;

   [HideInInspector]
   public bool isFacingLeft;

   private Vector2 facingLeft;



    void Start()
    {
        Initialization();
    }

    protected virtual void Initialization()
    {
        character = GetComponent<Character>();
        facingLeft = new Vector2(-transform.localScale.x, transform.localScale.y);
    }

    protected virtual void Flip()
    {
        if (isFacingLeft)
        {
            transform.localScale = facingLeft;
        }
        if (!isFacingLeft)
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }




}
