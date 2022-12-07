using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInfo : MonoBehaviour
{
   public enum info { Score,item, HighScore}
    public info uiType;

    Text myText;

    void Awake()
    {
        myText = GetComponent<Text>();
    }

    void LateUpdate()
    {
        switch (uiType)
        {
            case info.Score:
                //myText.text = string.Format("{0:D3}", GameManager.score);
                myText.text = "����"+ GameManager.score;
                break;
            case info.HighScore:
                myText.text = "�ְ�����"+ PlayerPrefs.GetInt("Score");
                break;

        }
    }
    
}
