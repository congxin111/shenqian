using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialog3 : MonoBehaviour
{
    public Animator ani;
    int i, flag;
    string text;
    void Awake()
    {
        text = "这一天，还是要来了，或许是无上力量的增长，或许是无尽轮回了另一个开端，还有其他可能吗？   ";//这是第一句
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
                        text = "(磁性的声音回荡在海底的巨石间，无数动物为之迷失方向，他将修长的手指并起，刺入一只巨大的海豚，开始吸食血液，很快海豚干瘪下来。)    ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 2:
                    {
                        text = "还是人类的血更好喝啊。";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 3:
                    {
                        text = "（他低头看了一下满地的人类骨骼残骸，舔了舔嘴唇。）   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 4:
                    {
                        text = "（这些残骸上的黑气，让他无比享受。）   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 5:
                    {
                        text = "（海拉从来没有见过如此颜色的大海。）   ";
                        ani.speed = 1;
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 6:
                    {
                        text = "（她的皮肤表面有一层淡淡的膜，帮助她阻挡海水的压力，海拉如同一条灵动的鱼。）   ";
                        ani.speed = 1;
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 7:
                    {
                        text = "海拉：\n果然是你。   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 8:
                    {
                        text = "祭司：\n是我。   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 9:
                    {
                        text = "（海拉拉弓射箭，被男人一把拍开……）   ";
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
