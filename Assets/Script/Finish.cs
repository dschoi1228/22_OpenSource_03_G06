using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{


    void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player"))
        {

            
                SceneManager.LoadScene("ClearScene");
          
            
        }
    }
}
