using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class PorteTrigger_Quiz6: MonoBehaviour
{
    //private Vector3 playerPosition;
    public GameObject Canvas_Quiz6; 
    public GameObject Canvas_Quiz6_pt2;
    public GameObject Trigger_Quiz6;
    private Vector3 initialLocalPosition;

    public GameObject Piano_disabilitare;

    public GameObject Canvas_FrecciaLampeggiante;
    public GameObject Canvas_FrecciaLampeggiante_inalto;
    public GameObject LuceMovimento;

    public AudioSource ascensore;
    public AudioSource ding;

    public GameObject Piano5;
    public GameObject Piano4;
    public GameObject Piano3;
    public GameObject Piano2;
    public GameObject Piano1;
    public GameObject Piano0;


    void Start()
    {
        Canvas_FrecciaLampeggiante.SetActive(false);
        LuceMovimento.SetActive(false);

        ascensore.Stop();
        ding.Stop();

        initialLocalPosition = GameObject.FindWithTag("Player").transform.localPosition;

        Piano5.SetActive(true);
        Piano4.SetActive(false);
        Piano3.SetActive(false);
        Piano2.SetActive(false);
        Piano1.SetActive(false);
        Piano0.SetActive(false);

    }
    

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //playerPosition = GameObject.FindWithTag("Player").transform.localPosition;
            
            StartCoroutine(Piano6());
        }
    }

    IEnumerator Piano6()
    {

        Canvas_Quiz6.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        yield return new WaitForSecondsRealtime(5);    
        Canvas_Quiz6.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;

        //  yield return new WaitForSecondsRealtime(2);

        Piano_disabilitare.SetActive(false);

        ascensore.Play();
        Canvas_FrecciaLampeggiante.SetActive(true);
        LuceMovimento.SetActive(true);

        yield return new WaitForSecondsRealtime(2);
        Piano5.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Piano4.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Piano4.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Piano3.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Piano3.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Piano2.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Piano2.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Piano1.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Piano1.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Piano0.SetActive(true);



        ding.Play();
        LuceMovimento.SetActive(true);
        Canvas_FrecciaLampeggiante.SetActive(true);

        GameObject.FindWithTag("Player").transform.DOLocalMove(initialLocalPosition, 5);

        LuceMovimento.SetActive(false);
        Canvas_FrecciaLampeggiante.SetActive(false);


        Cursor.lockState = CursorLockMode.Locked;

        yield return new WaitForSecondsRealtime(2);

        
        Canvas_Quiz6_pt2.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        yield return new WaitForSecondsRealtime(5);
        Canvas_Quiz6_pt2.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;

        //  yield return new WaitForSecondsRealtime(2);

        
        ascensore.Play();
        Canvas_FrecciaLampeggiante_inalto.SetActive(true);
        LuceMovimento.SetActive(true);

        yield return new WaitForSecondsRealtime(2);
        Piano0.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Piano1.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Piano1.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Piano2.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Piano2.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Piano3.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Piano3.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Piano4.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Piano4.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Piano5.SetActive(true);



        ding.Play();
        LuceMovimento.SetActive(true);
        Canvas_FrecciaLampeggiante_inalto.SetActive(true);

        GameObject.FindWithTag("Player").transform.DOLocalMove(initialLocalPosition, 5);

        LuceMovimento.SetActive(false);
        Canvas_FrecciaLampeggiante.SetActive(false);


        Cursor.lockState = CursorLockMode.Locked;

        yield return new WaitForSecondsRealtime(2);

        SceneManager.LoadScene(2);

        Trigger_Quiz6.SetActive(false);

    }
}

