using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PorteTrigger_Quiz4: MonoBehaviour
{
    //private Vector3 playerPosition;
    public GameObject Canvas_Quiz4;
    public GameObject Trigger_Quiz4;
    private Vector3 initialLocalPosition;

    public GameObject Canvas_FrecciaLampeggiante;
    public GameObject LuceMovimento;

    public AudioSource ascensore;
    public AudioSource ding;

    public GameObject luciEmergenza;



    void Start()
    {
        Canvas_Quiz4.SetActive(false);

        Canvas_FrecciaLampeggiante.SetActive(false);
        LuceMovimento.SetActive(false);

        ascensore.Stop();
        ding.Stop();

        initialLocalPosition = GameObject.FindWithTag("Player").transform.localPosition;

        luciEmergenza.SetActive(false);
    }
    

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //playerPosition = GameObject.FindWithTag("Player").transform.localPosition;
            
            StartCoroutine(Piano4());
        }
    }

    IEnumerator Piano4()
    {

        Canvas_Quiz4.SetActive(true);
        luciEmergenza.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        yield return new WaitForSecondsRealtime(30);
        Canvas_Quiz4.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;

       //  yield return new WaitForSecondsRealtime(2);

        ascensore.Play();
        yield return new WaitForSecondsRealtime(3);

        ding.Play();
        LuceMovimento.SetActive(true);
        Canvas_FrecciaLampeggiante.SetActive(true);

         GameObject.FindWithTag("Player").transform.DOLocalMove(initialLocalPosition, 5);

        yield return new WaitForSecondsRealtime(6);

        LuceMovimento.SetActive(false);

        ascensore.Stop();
        ding.Stop();
        
        Trigger_Quiz4.SetActive(false);  

    }
}

