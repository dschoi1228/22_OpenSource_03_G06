//using System.Collections;
//using System.Collections.Generic;
//using System.Collections.Specialized;
//using System.Security.Cryptography;
//using System.Threading;
//using UnityEngine;

//public class speedup : item
//{
//        // 10�ʰ� �̵��ӵ� 100% ���� 
//        private void OnTriggerEnter(Collider col)
//        {
//            if (col.CompareTag("Player"))
//            {
//                Player player = col.GetComponent<Player>();
//                StartCoroutine(IncreaseMoveSpeed(player));

//                GetComponent<MeshRenderer>().enabled = false;  // Destroy�� �ϸ� �ڷ�ƾ�� �����ǹǷ�, �ӽ÷� �׸��� ������.
//                GetComponent<SphereCollider>().enabled = false;      // �浹ü ����
//            }
//        }

//        IEnumerator IncreaseMoveSpeed(Player player)
//        {
//            float moveSpeed = player.getMoveSpeed();
//            player.SetMoveSpeed(moveSpeed * 2f);

//            yield return new WaitForSeconds(10);

//            player.SetMoveSpeed(moveSpeed);
//            Destroy(gameObject);
//        }

//}
