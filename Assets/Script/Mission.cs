using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
//using System.Net.NetworkInformation;
//using System.Security.Cryptography;
//using System.Threading;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Mission : MonoBehaviour
{
    public static Mission mission;

    public enum MissionType
    {
        cocoa, doughnut, cake, toast, cupcake, cup, display, croissant
    };

    public MissionType missionType;
    public Sprite DefaultImg; 
    public string missionName;
    public int value;
    public Inventory Iv;


    //public bool Use()
    //{
    //    return false;
    //}

    //void Awake()
    //{
    //    // �±׸��� "Inventory"�� ��ü�� GameObject�� ��ȯ�Ѵ�.
    //    // ��ȯ�� ��ü�� ������ �ִ� ��ũ��Ʈ�� GetComponent�� ���� �����´�.
    //    Iv = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();

    //}

    //void AddItem()
    //{
    //    // ������ ȹ�濡 ������ ���.
    //    if (!Iv.AddMission(this)) ;
    //    // Debug.Log("�������� ���� á���ϴ�.");
    //    else // ������ ȹ�濡 ������ ���.
    //        gameObject.SetActive(false); // �������� ��Ȱ��ȭ �����ش�.
    //}

    //// �浹üũ
    //void OnTriggerEnter(Collider _col)
    //{
    //    // �÷��̾�� �浹�ϸ�.
    //    if (_col.gameObject.layer == 10)
    //        AddItem();
    //}







    //void Update()
    //{
    //    transform.Rotate(Vector3.up * 15 * Time.deltaTime);
    //}


    //public Mission mission;
    //public SpriteRenderer image;

    //public void SetMission(Mission _mission)
    //{
    //    mission.missionName = _mission.missionName;
    //    mission.missionImage = _mission.missionImage;
    //    mission.missionType = _mission.missionType;

    //    image.sprite = mission.missionImage;

    //}
    //public Mission GetMission()
    //{
    //    return mission;
    //}
    //public void DestroyMission()
    //{
    //    Destroy(gameObject);
    //}

    
}
