using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialog5 : MonoBehaviour
{
    public Animator ani;
    int i, flag;
    string text;
    void Awake()
    {
        text = "(祭司死去的地方开始出现大量的黑气，这些黑气直接从海拉的七窍一涌而入。)    ";//这是第一句
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
                        text = "(海拉的身体开始变化，她的皮肤变得更加细腻，眼睛更加深邃，她的体温迅速下降，周围的海水结成了冰，海洋生物们被她的体香吸引，环绕着她。)      ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 2:
                    {
                        text = "(“榨干它们吧，你会有无穷的力量，寒冰之力，万人之上——”海拉的耳边传来蛊惑的声音。)      ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 3:
                    {
                        text = "(她知道祭司那句话的意思了，曾经他也是勇敢的少年……)      ";
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
            Debug.Log("文本内容：" + text + "文本长度" + text.Length + "当前索引：" + i);

            gameObject.GetComponent<TextMeshPro>().text = text.Substring(0, i);
        }
    }

}
