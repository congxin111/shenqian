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
        text = "��ô......\n��ô����������ö��뿪����...... ";//���ǵ�һ��
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
                        text = "(ҹ��������˫�������ǵ���ͫ͸�����Ӷ��ź������\n���Ż���Ӧ�ó�ȥ����)   ";
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
                        text = "��˾��\n�װ��ĺ�����������һ���������ͬѰ����ҹ������Ҫȥ�����أ�    ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 4:
                    {
                        ani.speed = 1;
                        text = "������\n�Һܼ�į��Ҫ���������ߡ�    ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 5:
                    {
                        text = "��˾:\n�벻Ҫ���գ���ļ��˶���Ϊ���������Ƕ�����İ������Ƕ��Ǵ����Ҹ���Ц���뿪��    ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 6:
                    {
                        ani.speed = 1;
                        text = "(�������ʧЧ���������൱��Ȥ����ֻ���������ķ����Ȼ�������Ǳߡ�ȥ�Ļ�����������Ҳ���������ˣ��Ǻ�)    ";
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
                        text = "(������ʶ����˾�ܹ����ݴ���)   ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 9:
                    {
                        text = "�����������뿪С����������������Թ��� ";
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
            Debug.Log("�ı����ݣ�" + text + "�ı�����" + text.Length + "��ǰ������" + i);

            gameObject.GetComponent<TextMeshPro>().text = text.Substring(0, i);
        }
    }

}
