using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    Vector3 pos; //������ġ

    float delta = 0.5f; // ��(��)�� �̵������� (y)�ִ밪

    float Item_speed = 3f; // �̵��ӵ�

    private void Start()
    {
        pos = this.transform.position;
    }

    private void Update()
    {
        Vector3 v = pos;
        v.y += delta * Mathf.Sin(Time.time * Item_speed);
        transform.position = v;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}