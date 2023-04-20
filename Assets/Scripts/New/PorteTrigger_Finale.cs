using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PorteTrigger_Finale : MonoBehaviour
{
    
    private Vector3 initialLocalPosition;

    public GameObject Trigger_Finale;
    public GameObject MessaggioFinale1;
    public GameObject MessaggioFinale2;
    public GameObject Canva_Finale;
    public GameObject Trigger_PublicSpeaking;
   

    public GameObject Canvas_FrecciaLampeggiante;
    public GameObject LuceMovimento;
    public AudioSource ascensore;
    public AudioSource ding;

    public GameObject StanzaFuori;

    public GameObject Piano5;
    public GameObject Piano4;
    public GameObject Piano3;
    public GameObject Piano2;
    public GameObject Piano1;
    public GameObject Piano0;
    public  GameObject UscitaGiocoCanva;

    public GameObject pc;
    public GameObject SediaUfficio;
    public GameObject computer;
    public GameObject stanzaPubSpeaking;
    public GameObject Muri;
    public GameObject Scrivania;
    public GameObject Finestre;

    public GameObject Trigger_Ringraziamento;
    public GameObject Ringraziamento;

    



    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        MessaggioFinale1.SetActive(false);
        MessaggioFinale2.SetActive(false);
        Canva_Finale.SetActive(false);
        UscitaGiocoCanva.SetActive(false);

        initialLocalPosition = GameObject.FindWithTag("Player").transform.localPosition;

        Canvas_FrecciaLampeggiante.SetActive(false);
        LuceMovimento.SetActive(false);
        ascensore.Stop();
        ding.Stop();

        StanzaFuori.SetActive(false);

        Piano5.SetActive(true);
        Piano4.SetActive(false);
        Piano3.SetActive(false);
        Piano2.SetActive(false);
        Piano1.SetActive(false);
        Piano0.SetActive(false);

        SediaUfficio.SetActive(true);
        pc.SetActive(true);
        computer.SetActive(true);
        stanzaPubSpeaking.SetActive(true);
        Muri.SetActive(true);
        Scrivania.SetActive(true);
        Finestre.SetActive(true);

        Trigger_Ringraziamento.SetActive(false);
        Ringraziamento.SetActive(false);

        

       
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            
            StartCoroutine(PianoFinale());
        }
    }

  IEnumerator PianoFinale()
  {
    Cursor.lockState = CursorLockMode.None;

    Canva_Finale.SetActive(true);

   // yield return new WaitForSecondsRealtime(1);

    MessaggioFinale1.SetActive(true);

    yield return new WaitForSecondsRealtime(2);

    MessaggioFinale1.SetActive(false);

    yield return new WaitForSecondsRealtime(2);

    MessaggioFinale2.SetActive(true);

    yield return new WaitForSecondsRealtime (2);

    Canva_Finale.SetActive(false);

    StanzaFuori.SetActive(true);

    ascensore.Play();
    Canvas_FrecciaLampeggiante.SetActive(true);
    LuceMovimento.SetActive(true);

        yield return new WaitForSecondsRealtime(2);
        Piano5.SetActive(false);
        yield return new WaitForSecondsRealtime(2);
        Piano4.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Piano4.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Piano3.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Piano4.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Piano3.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Piano3.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Piano2.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Piano2.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Piano1.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Piano1.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Piano0.SetActive(true);
        
        

        ding.Play();
        LuceMovimento.SetActive(true);
        Canvas_FrecciaLampeggiante.SetActive(true);

        GameObject.FindWithTag("Player").transform.DOLocalMove(initialLocalPosition, 5);

        LuceMovimento.SetActive(false);
    

        Cursor.lockState = CursorLockMode.Locked;

        yield return new WaitForSecondsRealtime(2);

        Canvas_FrecciaLampeggiante.SetActive(false);

        Trigger_Finale.SetActive(false);
        StanzaFuori.SetActive(false);
        UscitaGiocoCanva.SetActive(true);

        pc.SetActive(false);
        SediaUfficio.SetActive(false);
        computer.SetActive(false);
        stanzaPubSpeaking.SetActive(false);
        Muri.SetActive(false);
        Scrivania.SetActive(false);
        Finestre.SetActive(false);

        Trigger_Ringraziamento.SetActive(true);


        Trigger_PublicSpeaking.SetActive(false);
   
        
        




  }
}
