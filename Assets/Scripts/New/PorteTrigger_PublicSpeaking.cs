using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PorteTrigger_PublicSpeaking : MonoBehaviour
{

    private Vector3 initialLocalPosition;
    public GameObject Canvas_PublicSpeaking;
     public GameObject Trigger_PublicSpeaking;
   
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Canvas_PublicSpeaking.SetActive(false);

         initialLocalPosition = GameObject.FindWithTag("Player").transform.localPosition;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //playerPosition = GameObject.FindWithTag("Player").transform.localPosition;
            
            StartCoroutine(PublicSpeaking());

        }
    }

     IEnumerator PublicSpeaking()
    {
        Cursor.lockState = CursorLockMode.None;

        //yield return new WaitForSecondsRealtime(2);

        Canvas_PublicSpeaking.SetActive(true);

//30
        yield return new WaitForSecondsRealtime(10);

        Canvas_PublicSpeaking.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;

        



    }
}
