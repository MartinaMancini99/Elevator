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

    void Start()
    {
         Canvas_Quiz3.SetActive(false);
         
        Trigger_Quiz2.SetActive(false);
        Trigger_Quiz4.SetActive(false);

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

        //GameObject.FindWithTag("Player").transform.DOMove(playerPosition + new Vector3 (0, 0, 6), 5);
        GameObject.FindWithTag("Player").transform.DOLocalMove(initialLocalPosition, 5);

        yield return new WaitForSecondsRealtime(6);

        Trigger_Quiz4.SetActive(true);
        Trigger_Quiz3.SetActive(false);
        

    }
}
