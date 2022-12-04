using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniPause : MonoBehaviour
{
    Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void pause()
    {
        ani.speed = 0;
    }
}
