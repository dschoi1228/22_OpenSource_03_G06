using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Ʈ���� �ȿ� if ������ ������Ʈ�� Ȱ��ȭ �Ǿ� ������ ī��Ʈ �ٿ� 5�� 
// �ƴ϶�� if���� �����ؼ� 5�ʰ� ������Ʈ �� Ȱ��ȭ
// �÷��̾ 5�ʵ� Exit �ϸ� Count �ʱ�ȭ


public class H1G : MonoBehaviour
{
    float time = 5.0f;// �� �����ð� 5��
    int H1gp = 0;// �׶��� ���� Ȯ��
  

    private bool state;

    void Start()
    {
        state = false;
       
    }

    // Update is called once per frame
    void Update()
    {

        if (state == true && H1gp == 1) // ���� ���Խ� ���� Ȱ��ȭ ��Ű�� 
            //������� ���Ͻ� ���� H1gp�� 0���� �ʱ�ȭ ��Ŵ
        {
            gameObject.SetActive(true);
            H1gp = 0;
        }
        if (state == true && time > 0) // Ȱ��ȭ�� ���¿��� 0���� �۾����� Ż��
        {
            time -= Time.deltaTime;
        }

        else if (time <= 0) // 0���� �۾����� �� Ȱ��ȭ
        {
            gameObject.SetActive(false);
        }



        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") // �÷��̾ H1g �±� ���� ������ Ȱ��ȭ
        {

            state = true;
            H1gp = 1;
        }
       

    }

    void OnTriggerExit(Collider other)// �÷��̾ Ż���ϸ� ���� �������� �ٽ� ���� �����ϰ�
    {
        if (other.tag == "Player")
        {
            H1gp = 1;
            time = 5.0f;
        }


    }
}
