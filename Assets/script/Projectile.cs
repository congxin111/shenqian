using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();  
    }

   public void Launch(Vector2 direction,float force) { 
           
      rigidbody2d.AddForce(direction*force);  
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy ep = collision.gameObject.GetComponent<Enemy>();
        if (collision.gameObject.tag == "Enemy")
        {
            ep.GetHit();

            Destroy(gameObject);
        }
        
    }
   
}
