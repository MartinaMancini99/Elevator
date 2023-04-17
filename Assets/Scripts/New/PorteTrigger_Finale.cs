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


    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        initialLocalPosition = GameObject.FindWithTag("Player").transform.localPosition;
        MessaggioFinale1.SetActive(false);
        MessaggioFinale2.SetActive(false);
        Canva_Finale.SetActive(false);
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
    Canva_Finale.SetActive(true);
    yield return new WaitForSecondsRealtime(1);
    MessaggioFinale1.SetActive(true);
    yield return new WaitForSecondsRealtime(2);
    MessaggioFinale1.SetActive(false);
    yield return new WaitForSecondsRealtime(2);
    MessaggioFinale2.SetActive(true);


  }
}
