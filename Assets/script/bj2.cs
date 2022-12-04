using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class bj2 : MonoBehaviour
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
        if (transform.position.x < 1175)
            transform.position = new Vector3(3522, 540, 1);
    }
}

