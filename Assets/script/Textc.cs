using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textc : MonoBehaviour
{
    public float delay = 0.05f;
    string fullText = "\n“妈妈，爸爸呢？”小小的海拉向妈妈提出了这样的问题。\n“爸爸已经成为了大海的一部分了，他是拯救我们的英雄，与他一起的，还有你的哥哥。”......   ";
    string currentText;
    void Start()
    {
        StartCoroutine(ShowText());
    }
    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)//遍历插入字符串的长度
        {
            currentText = fullText.Substring(0, i);//看demo1的代码注释
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);//每次延迟的时间 数值越小 延迟越少
        }
    }
}
