using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PorteTrigger_Quiz9 : MonoBehaviour
{

    public GameObject Trigger_Quiz9;
    private Vector3 initialLocalPosition;
    public GameObject Canvas_Quiz9_1; //Congratulazioni_Canvas
    public GameObject Canvas_Quiz9_2;
    public GameObject Canvas_Quiz9_3;
    public GameObject Canvas_Quiz9_4;
    public GameObject Trigger_Finale;
    public GameObject Canva_Finale;
    public GameObject StanzaFuori;
    
    public GameObject LuceMovimento;

    public GameObject Piano5;
    public GameObject Piano4;
    public GameObject Piano3;
    public GameObject Piano2;
    public GameObject Piano1;
    public GameObject Piano0;

    public GameObject UscitaGioco;
    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Canvas_Quiz9_1.SetActive(false);
        Canvas_Quiz9_2.SetActive(false);
        Canvas_Quiz9_3.SetActive(false);
        Canvas_Quiz9_4.SetActive(false);
        Trigger_Finale.SetActive(false);
        Canva_Finale.SetActive(false);
        Piano5.SetActive(true);
        Piano4.SetActive(false);
        Piano3.SetActive(false);
        Piano2.SetActive(false);
        Piano1.SetActive(false);
        Piano0.SetActive(false);
        LuceMovimento.SetActive(false);
        
        initialLocalPosition = GameObject.FindWithTag("Player").transform.localPosition;

        StanzaFuori.SetActive(false);
        UscitaGioco.SetActive(false);
        
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //playerPosition = GameObject.FindWithTag("Player").transform.localPosition;
            
            StartCoroutine(Piano9());
        }
    }

    IEnumerator Piano9()
    {
        Cursor.lockState = CursorLockMode.None; 

        Canvas_Quiz9_1.SetActive(true);

        yield return new WaitForSecondsRealtime(3);

        Canvas_Quiz9_1.SetActive(false);

        yield return new WaitForSecondsRealtime(3);

        Canvas_Quiz9_2.SetActive(true);

        yield return new WaitForSecondsRealtime(3);

        Canvas_Quiz9_2.SetActive(false);

        yield return new WaitForSecondsRealtime(3);

        Canvas_Quiz9_3.SetActive(true);

        yield return new WaitForSecondsRealtime(3);

        Cursor.lockState = CursorLockMode.None; 

        Canvas_Quiz9_3.SetActive(false);

        yield return new WaitForSecondsRealtime(3);



        //  Cursor.lockState = CursorLockMode.Locked;

        Canvas_Quiz9_4.SetActive(true);

        yield return new WaitForSecondsRealtime(5);

        Canvas_Quiz9_4.SetActive(false);

      //  GameObject.FindWithTag("Player").transform.DOLocalMove(initialLocalPosition, 5);
         yield return new WaitForSecondsRealtime(2);

        // Trigger_Finale.SetActive(true);

        Cursor.lockState = CursorLockMode.Locked; 
        //Trigger_Finale.SetActive(true);
         Trigger_Quiz9.SetActive(false);
 Trigger_Finale.SetActive(true);
    
    }


    
}
