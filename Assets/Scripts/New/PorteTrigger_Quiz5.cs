using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PorteTrigger_Quiz5: MonoBehaviour
{
    //private Vector3 playerPosition;
    public GameObject Canvas_Quiz5;
    public GameObject Breadboard;
    public Camera MainCamera;
    public Camera CameraBreaboard;
    public GameObject Trigger_Quiz5;
    public GameObject Trigger_Quiz6;
    private Vector3 initialLocalPosition;

    public GameObject Canvas_FrecciaLampeggiante;
    public GameObject LuceMovimento;

    public AudioSource ascensore;
    public AudioSource ding;


    void Start()
    {
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
            
            StartCoroutine(Piano5());
        }
    }

    IEnumerator Piano5()
    {
        Cursor.lockState = CursorLockMode.None;
        Canvas_Quiz5.SetActive(true);
        
        yield return new WaitForSecondsRealtime(5);
        Canvas_Quiz5.SetActive(false);

        CameraBreaboard.enabled = true;
        MainCamera.enabled = false;

        Breadboard.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        yield return new WaitForSecondsRealtime(15);     //30
        Breadboard.SetActive(false);

        MainCamera.enabled = true;
        CameraBreaboard.enabled = false;

        Cursor.lockState = CursorLockMode.Locked;

       //  yield return new WaitForSecondsRealtime(2);

        ascensore.Play();
        yield return new WaitForSecondsRealtime(3);

        ding.Play();
        LuceMovimento.SetActive(true);
        Canvas_FrecciaLampeggiante.SetActive(true);

        GameObject.FindWithTag("Player").transform.DOLocalMove(initialLocalPosition, 5);

        yield return new WaitForSecondsRealtime(5);

        LuceMovimento.SetActive(false);
        Canvas_FrecciaLampeggiante.SetActive(false);

        ascensore.Stop();
        ding.Stop();
        
        Trigger_Quiz6.SetActive(true);
        Trigger_Quiz5.SetActive(false);

    }
}

