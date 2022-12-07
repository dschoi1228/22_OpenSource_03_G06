using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMenuUI : MonoBehaviour
{
    public void OnClickOnlineButton()
    {
        Debug.Log("Click Online");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif


        }
    }
    public void OnClickQuitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
