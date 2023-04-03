using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PorteTrigger_Quiz4: MonoBehaviour
{
    //private Vector3 playerPosition;
    public GameObject Canvas_Quiz4;
    public GameObject Trigger_Quiz4;

    void Start()
    {
        
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
        Cursor.lockState = CursorLockMode.None;
        yield return new WaitForSecondsRealtime(30);
        Cursor.lockState = CursorLockMode.Locked;
        Canvas_Quiz4.SetActive(false);
        Trigger_Quiz4.SetActive(false);  

    }
}

