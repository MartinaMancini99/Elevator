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
     public GameObject Trigger_Quiz9;
     public GameObject Trigger_Finale;
     public GameObject Canva_Finale;
    public AudioSource ascensore;
    public AudioSource ding;


     public GameObject StanzaFuori;

     public GameObject LuceMovimento;
     public GameObject Canvas_FrecciaLampeggiante;

     public GameObject Piano5;
     public GameObject Piano4;
     public GameObject Piano3;
     public GameObject Piano2;
     public GameObject Piano1;
     public GameObject Piano0;

     public GameObject Trigger_Ringraziamento;
     public GameObject Ringraziamento;
     
     public GameObject UscitaGiocoCanva;



   
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Canvas_PublicSpeaking.SetActive(false);
        Canva_Message1.SetActive(false);
        Canva_Message2.SetActive(false);
        Trigger_Quiz9.SetActive(false);
        Trigger_Finale.SetActive(false);
        Canva_Finale.SetActive(false);
        Piano5.SetActive(true);
        Piano4.SetActive(false);
        Piano3.SetActive(false);
        Piano2.SetActive(false);
        Piano1.SetActive(false);
        Piano0.SetActive(false);

        LuceMovimento.SetActive(false);
        Canvas_FrecciaLampeggiante.SetActive(false);
        
        ascensore.Stop();
        ding.Stop();
        message.Stop();
        
        initialLocalPosition = GameObject.FindWithTag("Player").transform.localPosition;

        StanzaFuori.SetActive(false);

        Trigger_Ringraziamento.SetActive(false);
        Ringraziamento.SetActive(false);
        
        UscitaGiocoCanva.SetActive(false);
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
        yield return new WaitForSecondsRealtime(10);

        Canvas_PublicSpeaking.SetActive(false);
        GameObject.FindWithTag("Player").transform.DOLocalMove(initialLocalPosition, 5);

        Cursor.lockState = CursorLockMode.Locked;

        Trigger_Quiz9.SetActive(true);

        



    }
}