using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Ʈ���� �ȿ� if ������ ������Ʈ�� Ȱ��ȭ �Ǿ� ������ ī��Ʈ �ٿ� 5�� 
// �ƴ϶�� if���� �����ؼ� 5�ʰ� ������Ʈ �� Ȱ��ȭ
// �÷��̾ 5�ʵ� Exit �ϸ� Count �ʱ�ȭ


public class H1GP : MonoBehaviour
{



    float time = 5.0f;
    int H1g = 0;
    int speed;

   

    // Update is called once per frame
    void Update()
    {
        if (H1g == 1 && time > 0)//���� �ð��� ���� Ʈ���� H=1 time�� 5
        {
            time -= Time.deltaTime;
            speed = 3;
        }
        else if (H1g == 1 && time <= 0)// Ʈ���Ű� Ȱ��ȭ ��µ� �ð��� ����Ǿ��ٸ�
        {
            H1g = 0;
            time = 5.0f;
            speed = 15;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "H1g")
        {
            H1g = 1;

        }
       

    }
}
