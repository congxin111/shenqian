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
        text = "��˾��\n����Ϊ�����ˣ�    ";//���ǵ�һ��
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
                        text = "(��˾�����廯Ϊ����֮ǰ������������һ�仰��)      ";
                        ani.speed = 1;
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 2:
                    {
                        text = "(����֪����Ȼ��ֻ��������������)      ";
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
