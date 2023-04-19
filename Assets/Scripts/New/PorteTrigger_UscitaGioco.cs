using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PorteTrigger_UscitaGioco : MonoBehaviour
{
    private Vector3 initialLocalPosition; 

    public GameObject Trigger_UscitaGioco;
    public GameObject UscitaGioco;
    
    public GameObject StanzaFuori;

    public GameObject Canvas_FrecciaLampeggiante;
    public GameObject LuceMovimento;

    
    // Start is called before the first frame update
    void Start()
    {
         Cursor.lockState = CursorLockMode.Locked;
         UscitaGioco.SetActive(false);
         StanzaFuori.SetActive(false);
         initialLocalPosition = GameObject.FindWithTag("Player").transform.localPosition;
        Canvas_FrecciaLampeggiante.SetActive(false);
        LuceMovimento.SetActive(false);
         

    }

     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            
            StartCoroutine(PianoUscitaGioco());
        }
    }

    IEnumerator PianoUscitaGioco()
    {
        Cursor.lockState = CursorLockMode.None;
        UscitaGioco.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
    }

    
}
