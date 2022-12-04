using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bj : MonoBehaviour
{
    public float speed = -1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0);
             if (transform.position.x < -1177 )
            transform.position = new Vector3(1170,540,0);
    }
}
