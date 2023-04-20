using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PorteTrigger_Quiz3: MonoBehaviour
{
    //private Vector3 playerPosition;
    //public GameObject AllarmeBlocco;
      public GameObject Trigger_Quiz3;
      private Vector3 initialLocalPosition;
      public GameObject Trigger_Quiz4;
      public GameObject Canvas_Quiz3;
      public GameObject Trigger_Quiz2;

      public GameObject LuceMovimento;
      public GameObject Canvas_FrecciaLampeggiante;

      public AudioSource ascensore;
      public AudioSource ding;


    void Start()
    {
        Canvas_Quiz3.SetActive(false);
         
        Trigger_Quiz2.SetActive(false);
        Trigger_Quiz4.SetActive(false);

        Canvas_FrecciaLampeggiante.SetActive(false);
        LuceMovimento.SetActive(false);

        ascensore.Stop();
        ding.Stop();


        initialLocalPosition = GameObject.FindWithTag("Player").transform.localPosition;
    }
    

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
         //playerPosition = GameObject.FindWithTag("Player").transform.localPosition;    
         StartCoroutine(Piano3());
        }
    }

    IEnumerator Piano3()
    {

        Canvas_Quiz3.SetActive(true);

        //30
        yield return new WaitForSecondsRealtime(5);
        Canvas_Quiz3.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
       //   yield return new WaitForSecondsRealtime(2);

        ascensore.Play();
        yield return new WaitForSecondsRealtime(3);

        ding.Play();
        LuceMovimento.SetActive(true);

        
        Canvas_FrecciaLampeggiante.SetActive(true);

        //GameObject.FindWithTag("Player").transform.DOMove(playerPosition + new Vector3 (0, 0, 6), 5);
        GameObject.FindWithTag("Player").transform.DOLocalMove(initialLocalPosition, 5);

        yield return new WaitForSecondsRealtime(5);

        LuceMovimento.SetActive(false);
        Canvas_FrecciaLampeggiante.SetActive(false);

        ascensore.Stop();
        ding.Stop();

        Trigger_Quiz4.SetActive(true);
        Trigger_Quiz3.SetActive(false);



    }
}

