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
        text = "Ϊʲô�ҵ�����ꪻ���������������֡� ";//���ǵ�һ��
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
                        text = "(�����������е�����ꪣ������˰��ƶ�����ǰ����˵���Ļ�...)   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        ani.speed = 1;
                        break;
                    }
                case 2:
                    {
                        text = "���ƶ���\n������������ģ�   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        ani.speed = 1;
                        break;
                    }
                case 3:
                    {
                        text = "������\n��������ñ�ѡ����ȥ�����ˣ��Ժ��ҿ�����Ҳ������������  ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 4:
                    {
                        text = "���ƶ���\n���룿ʲô���룿   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 5:
                    {
                        text = "������\nһ��������ֹ��Х�ļ��롣   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 6:
                    {
                        text = "���ƶ���\n�����뺣Х��ʲô��ϵ�����Ǵ��Ӵ��������룬Ҳ���ٷ�����Х�������к�Х������Ҳ����ȫ�Ĵ�ʩ������ʧ��   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
            }
                case 7:
                    {
                        text = "������ֱ�����Ķ��Ű��ƶ������ƶ���Щ�����ʴӣ�  ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 8:
                    {
                        text = "���ƶ���\n��......��ô��......   ";
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
            Debug.Log("�ı����ݣ�" + text + "�ı�����" + text.Length + "��ǰ������" + i);

            gameObject.GetComponent<TextMeshPro>().text = text.Substring(0, i);
        }
    }

}
