using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PorteTrigger_Quiz2 : MonoBehaviour
{
    //private Vector3 playerPosition;
    public GameObject Fumo;
    public GameObject Trigger_Quiz2;

    void Start()
    {
        
    }
    

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //playerPosition = GameObject.FindWithTag("Player").transform.localPosition;
            
            StartCoroutine(Piano2());
        }
    }

    IEnumerator Piano2()
    {

        Fumo.SetActive(true);
        yield return new WaitForSecondsRealtime(30);
        Fumo.SetActive(false);
        Trigger_Quiz2.SetActive(false);  

    }
}
