using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PorteTrigger_Quiz1 : MonoBehaviour
{
    //private Vector3 playerPosition;
    private Vector3 initialLocalPosition;
    
    public GameObject Canvas_Quiz1;
    public GameObject Trigger_Quiz1;
    public GameObject Trigger_Quiz2;
    public GameObject Trigger_Quiz3;
    public GameObject Trigger_Quiz4;

    public GameObject Canvas_FrecciaLampeggiante;
    public GameObject LuceMovimento;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Canvas_Quiz1.SetActive(false);

        Trigger_Quiz2.SetActive(false);
        Trigger_Quiz3.SetActive(false);
        Trigger_Quiz4.SetActive(false);
        Canvas_FrecciaLampeggiante.SetActive(false);
        LuceMovimento.SetActive(false);

        initialLocalPosition = GameObject.FindWithTag("Player").transform.localPosition;


        //playerPosition = GameObject.FindWithTag("Player").transform.localPosition;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //playerPosition = GameObject.FindWithTag("Player").transform.localPosition;
            
            StartCoroutine(Piano1());

        }
    }

    IEnumerator Piano1()
    {
        Cursor.lockState = CursorLockMode.None;

        //yield return new WaitForSecondsRealtime(2);

        Canvas_Quiz1.SetActive(true);

//30
        yield return new WaitForSecondsRealtime(5);

        Canvas_Quiz1.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;

        LuceMovimento.SetActive(true);

        Canvas_FrecciaLampeggiante.SetActive(true);

        //GameObject.FindWithTag("Player").transform.DOMove(playerPosition + new Vector3 (0, 0, 6), 5);
        GameObject.FindWithTag("Player").transform.DOLocalMove(initialLocalPosition, 5);


        yield return new WaitForSecondsRealtime(6);

        LuceMovimento.SetActive(false);

        Trigger_Quiz2.SetActive(true);

        Trigger_Quiz1.SetActive(false);  



    }


}
