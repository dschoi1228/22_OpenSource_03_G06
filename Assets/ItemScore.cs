using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemScore : MonoBehaviour
{
    Text text;
    public static int score;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = "����: " + score.ToString();
    }
}
