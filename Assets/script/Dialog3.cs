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
        text = "��һ�죬����Ҫ���ˣ������������������������������޾��ֻ�����һ�����ˣ���������������   ";//���ǵ�һ��
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
                        text = "(���Ե������ص��ں��׵ľ�ʯ�䣬��������Ϊ֮��ʧ���������޳�����ָ���𣬴���һֻ�޴�ĺ��࣬��ʼ��ʳѪҺ���ܿ캣��ɱ�������)    ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 2:
                    {
                        text = "���������Ѫ���úȰ���";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 3:
                    {
                        text = "������ͷ����һ�����ص���������к����������촽����   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 4:
                    {
                        text = "����Щ�к��ϵĺ����������ޱ����ܡ���   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 5:
                    {
                        text = "����������û�м��������ɫ�Ĵ󺣡���   ";
                        ani.speed = 1;
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 6:
                    {
                        text = "������Ƥ��������һ�㵭����Ĥ���������赲��ˮ��ѹ����������ͬһ���鶯���㡣��   ";
                        ani.speed = 1;
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 7:
                    {
                        text = "������\n��Ȼ���㡣   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 8:
                    {
                        text = "��˾��\n���ҡ�   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 9:
                    {
                        text = "���������������������һ���Ŀ�������   ";
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
            Debug.Log("�ı����ݣ�" + text + "�ı�����" + text.Length + "��ǰ������" + i);

            gameObject.GetComponent<TextMeshPro>().text = text.Substring(0, i);
        }
    }

}
