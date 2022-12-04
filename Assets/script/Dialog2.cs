using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialog2 : MonoBehaviour
{
    public Animator ani;
    int i, flag;
    string text;
    void Awake()
    {
        text = "为什么我的三叉戟会出现在这里，真是奇怪。 ";//这是第一句
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
                        text = "(海拉望着手中的三叉戟，想起了艾菲尔几天前对她说过的话...)   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        ani.speed = 1;
                        break;
                    }
                case 2:
                    {
                        text = "艾菲尔：\n海拉最近不开心？   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        ani.speed = 1;
                        break;
                    }
                case 3:
                    {
                        text = "海拉：\n妈妈和妹妹被选中拿去祭祀了，以后我可能再也见不到她们了  ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 4:
                    {
                        text = "艾菲尔：\n祭祀？什么祭祀？   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 5:
                    {
                        text = "海拉：\n一个可以阻止海啸的祭祀。   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 6:
                    {
                        text = "艾菲尔：\n祭祀与海啸有什么关系，我们村子从来不祭祀，也很少发生海啸，就算有海啸，我们也有完全的措施减少损失。   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
            }
                case 7:
                    {
                        text = "（海拉直勾勾的盯着艾菲尔，艾菲尔有些无所适从）  ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 8:
                    {
                        text = "艾菲尔：\n怎......怎么了......   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 9:
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
