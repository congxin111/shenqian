using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class TriggerDetection : MonoBehaviour
{
    public GameObject key;
    public GameObject bow;
    public GameObject trident;
    // Start is called before the first frame update
    public GameObject TextEnable;
    void OnTriggerEnter2D(Collider2D other) 
	{
            if (other.gameObject.CompareTag("Key"))
            {
                other.gameObject.SetActive(false);
            }
            if (other.gameObject.CompareTag("Bow"))
            {
                other.gameObject.SetActive(false);

            }
            if (other.gameObject.CompareTag("Trident"))
            {
                other.gameObject.SetActive(false);
                TextEnable.gameObject.SetActive(true);
            }
        if (other.gameObject.CompareTag("MazeExit"))
        {
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
        if (other.gameObject.CompareTag("TextBox"))
        {
            other.gameObject.layer=LayerMask.NameToLayer("UI");
            other.transform.GetComponent<Collider2D>().enabled = false;
            IEnumerator close()
            {
                yield return new WaitForSeconds(1.5f);
                other.gameObject.layer = LayerMask.NameToLayer("TextBox");
            }
            StartCoroutine(close());
            StopCoroutine(close());
        }
	}
}
