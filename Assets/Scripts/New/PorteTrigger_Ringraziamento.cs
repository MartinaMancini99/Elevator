using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteTrigger_Ringraziamento : MonoBehaviour
{
    public GameObject Canva_Ringraziamento;
    public GameObject MessaggioRingraziamento1;
    public GameObject MessaggioRingraziamento2;

    public GameObject Trigger_Ringraziamento;


    // Start is called before the first frame update
    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
        MessaggioRingraziamento1.SetActive(false);
        MessaggioRingraziamento2.SetActive(false);

      Canva_Ringraziamento.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            
            StartCoroutine(PianoRingraziamento());
        }
    }

    IEnumerator PianoRingraziamento()
    {
         Cursor.lockState = CursorLockMode.None;
        

        Canva_Ringraziamento.SetActive(true);

        //yield return new WaitForSecondsRealtime(1);
        MessaggioRingraziamento1.SetActive(true);

        yield return new WaitForSecondsRealtime(3);
        MessaggioRingraziamento1.SetActive(false);

        yield return new WaitForSecondsRealtime(1);
        MessaggioRingraziamento2.SetActive(true);

        yield return new WaitForSecondsRealtime(3);
        MessaggioRingraziamento2.SetActive(false);
    }
}
