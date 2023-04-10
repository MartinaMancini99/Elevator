using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PorteTrigger_PublicSpeaking : MonoBehaviour
{

    private Vector3 initialLocalPosition;
    public GameObject Canvas_PublicSpeaking;
     public GameObject Trigger_PublicSpeaking;
     public GameObject Canva_Message1;
     public GameObject Canva_Message2;
     public AudioSource message;


   
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Canvas_PublicSpeaking.SetActive(false);
        Canva_Message1.SetActive(false);
        Canva_Message2.SetActive(false);

 
        message.Stop();

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

        yield return new WaitForSecondsRealtime(3);

        Canva_Message1.SetActive(true);

        message.Play();

        yield return new WaitForSecondsRealtime(5);

        Canva_Message2.SetActive(true);
        message.Play();

      

//30
        yield return new WaitForSecondsRealtime(30);

        Canvas_PublicSpeaking.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;

        



    }
}
