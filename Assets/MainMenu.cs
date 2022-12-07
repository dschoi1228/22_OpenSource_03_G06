using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    



    public GameObject MainCanvas;
    public GameObject GameStartCanvas;
    public GameObject countdownUI;
    public GameObject IngameUI;
    public GameObject EndUI;
  

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnClickNewGame()
    {
        Debug.Log("�� ����");
        MainCanvas.gameObject.SetActive(false);
        GameStartCanvas.gameObject.SetActive(true);
        countdownUI.gameObject.SetActive(false);
        IngameUI.gameObject.SetActive(false);
    }
    public void OnClickLoad()
    {
        Debug.Log("â�ݱ�");
        MainCanvas.gameObject.SetActive(false);
        IngameUI.gameObject.SetActive(true);
    }
    public void OnClickMap()
    {
        Debug.Log("��");
    }
    public void OnClickCustom()
    {
        Debug.Log("�ڽ���");
    }
    public void OnClickOption()
    {
        Debug.Log("�ɼ�");
    }
    public void OnClickRank()
    {
        Debug.Log("����ǥ");
        
}
    public void OnClickText()
    {
        Debug.Log("����");
    }
    public void OnClickQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
   

    public void OnClickReGame()
    {
        Debug.Log("�ٽð��ӽ���");
        MainCanvas.gameObject.SetActive(true);
        EndUI.gameObject.SetActive(false);

    }
}
