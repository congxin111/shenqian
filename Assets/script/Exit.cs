using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public GameObject key;
    public GameObject bow;
    public GameObject trident;
    void ExitTrigger(Collider2D other)
    {
        if (other.gameObject.CompareTag("MazeExit"))
        {
            Debug.Log("0");
            if (!(key.activeSelf || bow.activeSelf || trident.activeSelf))
            {
                SceneManager.LoadScene(4);
                Debug.Log("1");
            }
            else
            {
                Debug.Log("2");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
