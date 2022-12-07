using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using static System.Net.Mime.MediaTypeNames;

public class Slot : MonoBehaviour
{
   
    public Stack<Mission> slot;       // ������ �������� �����.
    private Image MissionImg;
    private bool isSlot;     // ���� ������ ����ִ���?

    public Mission MissionReturn() { return slot.Peek(); } // ���Կ� �����ϴ� �������� ���� ��ȯ.
    public bool isSlots() { return isSlot; } // ������ ���� ����ִ���? �� ���� �÷��� ��ȯ.
    public void SetSlots(bool isSlot) { this.isSlot = isSlot; }

    void Start()
    {
        // ���� �޸� �Ҵ�.
        slot = new Stack<Mission>();
        
        // �� ó���� ������ ����ִ�.
        isSlot = false;
        MissionImg = transform.Find("Mission").GetComponent<Image>();
    }

    public void AddMission(Mission mission)
    {
        // ���ÿ� ������ �߰�.
        slot.Push(mission);
        UpdateInfo(true, mission.DefaultImg);
    }

    // ���Կ� ���� ���� ���� ������Ʈ.
    public void UpdateInfo(bool isSlot, Sprite sprite)
    {
        SetSlots(isSlot);                                          // ������ ����ִٸ� false �ƴϸ� true ����.
        MissionImg.sprite = sprite;                                   // ���Ծȿ� ����ִ� �������� �̹����� ����.
        //MissionIO.SaveDate();                                         // �κ��丮�� ���������� �������Ƿ� ����.
    }
}
