using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialog4 : MonoBehaviour
{
    public Animator ani;
    int i, flag;
    string text;
    void Awake()
    {
        text = "祭司：\n你以为结束了？    ";//这是第一句
        StartCoroutine(Typer());
        StopCoroutine(Typer());
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            flag++;

            switch (flag)
            {
                case 1:
                    {
                        text = "(祭司的身体化为虚无之前，留下了这样一句话。)      ";
                        ani.speed = 1;
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 2:
                    {
                        text = "(她不知所以然，只觉得隐隐不安。)      ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                default:
                    {
                        ani.speed = 1;
                        break;
                    }
            }
        }
    }
    IEnumerator Typer()
    {
        for (i = 1; i < text.Length; i++)
        {
            yield return new WaitForSeconds(0.05f);
            gameObject.GetComponent<TextMeshPro>().text = text.Substring(0, i);
        }
    }

}
