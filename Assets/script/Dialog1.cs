using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialog1 : MonoBehaviour
{
    public Animator ani;
    int i, flag;
    string text;
    void Awake()
    {
        text = "怎么......\n怎么连妈妈和妹妹都离开我了...... ";//这是第一句
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
                        text = "(夜晚，海拉那双摄人心魄的蓝瞳透过窗子盯着海的深处。\n想着或许应该出去走走)   ";
                        ani.speed = 1;
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 2:
                    {
                        text = "         ";
                        ani.speed = 1;
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 3:
                    {
                        ani.speed = 1;
                        text = "祭司：\n亲爱的海拉，在这样一个美妙而不同寻常的夜晚，你想要去哪里呢？    ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 4:
                    {
                        ani.speed = 1;
                        text = "海拉：\n我很寂寞，要到海边走走。    ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 5:
                    {
                        text = "祭司:\n请不要苦恼，你的家人都是为了拯救我们而献身的啊，他们都是带着幸福的笑容离开的    ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 6:
                    {
                        ani.speed = 1;
                        text = "(精神控制失效了吗，真是相当有趣啊，只不过，她的方向既然是往“那边”去的话，恐怕是再也见不到她了，呵呵)    ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 7:
                    {
                        ani.speed = 1;
                        text = "        ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 8:
                    {
                        text = "(海拉意识到祭司能够操纵村民)   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 9:
                    {
                        text = "（海拉决心离开小镇，走向无人涉足的迷宫） ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 10:
                    {
                        ani.speed = 1;
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
