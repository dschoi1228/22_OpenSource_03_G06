using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item2 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            GameManager.GetItem();
            //�������
            //����
            Destroy(gameObject);
        }
    }
}
