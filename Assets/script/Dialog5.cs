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
        text = "(��˾��ȥ�ĵط���ʼ���ִ����ĺ�������Щ����ֱ�ӴӺ���������һӿ���롣)    ";//���ǵ�һ��
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
                        text = "(���������忪ʼ�仯������Ƥ����ø���ϸ�壬�۾��������䣬��������Ѹ���½�����Χ�ĺ�ˮ����˱������������Ǳ�������������������������)      ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 2:
                    {
                        text = "(��ե�����ǰɣ���������������������֮��������֮�ϡ����������Ķ��ߴ����ƻ��������)      ";
                        StartCoroutine(Typer());
                        StopCoroutine(Typer());
                        break;
                    }
                case 3:
                    {
                        text = "(��֪����˾�Ǿ仰����˼�ˣ�������Ҳ���¸ҵ����ꡭ��)      ";
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
