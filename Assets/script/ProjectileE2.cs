using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileE2 : MonoBehaviour
{
   public Vector3 dirction;
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += dirction * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Move ep = collision.GetComponent<Move>();
        if (collision.gameObject.tag == "Player")
        {
            ep.GetHit();

            Destroy(gameObject);
        }

    }
}
