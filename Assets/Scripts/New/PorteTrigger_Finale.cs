using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PorteTrigger_Finale : MonoBehaviour
{

    public GameObject Trigger_Finale;
    private Vector3 initialLocalPosition;
    public GameObject MessaggioFinale1;
    public GameObject MessaggioFinale2;
    public GameObject Canva_Finale;

    public GameObject Canvas_FrecciaLampeggiante;
    public GameObject LuceMovimento;

    public AudioSource ascensore;
    public AudioSource ding;

    public GameObject StanzaFuori;



    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        MessaggioFinale1.SetActive(false);
        MessaggioFinale2.SetActive(false);
        Canva_Finale.SetActive(false);

        initialLocalPosition = GameObject.FindWithTag("Player").transform.localPosition;

        Canvas_FrecciaLampeggiante.SetActive(false);
        LuceMovimento.SetActive(false);
        ascensore.Stop();
        ding.Stop();

        StanzaFuori.SetActive(false);
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
        yield return new WaitForSecondsRealtime(3);

        ding.Play();

        LuceMovimento.SetActive(true);

        Canvas_FrecciaLampeggiante.SetActive(true);

    GameObject.FindWithTag("Player").transform.DOLocalMove(initialLocalPosition, 5);

        Cursor.lockState = CursorLockMode.Locked;



  }
}
