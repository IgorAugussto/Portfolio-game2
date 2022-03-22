using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    public float JumpForce;

    private Rigidbody2D rig;
    private bool isJumping;


    
    void Start()
    {
      rig = GetComponent<Rigidbody2D>();  
    }

    
    void Update()
    {
      rig.velocity = new Vector2(Speed, rig.velocity.y);
      

      if(!(!Input.GetMouseButtonDown(0) || isJumping))
        {
          rig.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
          isJumping = true;
      }  
      
    }

    void OnCollisionEnter2D(Collision2D colisor)
    {
        if(colisor.gameObject.layer == 6){
            isJumping = false;
        }
    }
}
