using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textc : MonoBehaviour
{
    public float delay = 0.05f;
    string fullText = "\n�����裬�ְ��أ���СС�ĺ�����������������������⡣\n���ְ��Ѿ���Ϊ�˴󺣵�һ�����ˣ������������ǵ�Ӣ�ۣ�����һ��ģ�������ĸ�硣��......   ";
    string currentText;
    void Start()
    {
        StartCoroutine(ShowText());
    }
    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)//���������ַ����ĳ���
        {
            currentText = fullText.Substring(0, i);//��demo1�Ĵ���ע��
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);//ÿ���ӳٵ�ʱ�� ��ֵԽС �ӳ�Խ��
        }
    }
}
