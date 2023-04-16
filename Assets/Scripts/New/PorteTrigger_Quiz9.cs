using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteTrigger_Quiz9 : MonoBehaviour
{

    public GameObject Trigger_Quiz9;
    private Vector3 initialLocalPosition;
    public GameObject Canvas_Quiz9_1; //Congratulazioni_Canvas
    public GameObject Canvas_Quiz9_2;
    public GameObject Canvas_Quiz9_3;
    public GameObject Canvas_Quiz9_4;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Canvas_Quiz9_1.SetActive(false);
        Canvas_Quiz9_2.SetActive(false);
        Canvas_Quiz9_3.SetActive(false);
        Canvas_Quiz9_4.SetActive(false);
        initialLocalPosition = GameObject.FindWithTag("Player").transform.localPosition;
        
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

        yield return new WaitForSecondsRealtime(2);

        Canvas_Quiz9_1.SetActive(false);

        yield return new WaitForSecondsRealtime(2);

        Canvas_Quiz9_2.SetActive(true);

        yield return new WaitForSecondsRealtime(2);

        Canvas_Quiz9_2.SetActive(false);

        yield return new WaitForSecondsRealtime(2);

        Canvas_Quiz9_3.SetActive(true);

        yield return new WaitForSecondsRealtime(2);

        Cursor.lockState = CursorLockMode.None; 

        Canvas_Quiz9_3.SetActive(false);

        yield return new WaitForSecondsRealtime(2);



        //  Cursor.lockState = CursorLockMode.Locked;

        Canvas_Quiz9_4.SetActive(true);






    
    }


    
}
