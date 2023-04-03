using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAlarm : MonoBehaviour
{

   [SerializeField] AudioSource alert;

    // Start is called before the first frame update
    void Start()
    {
        alert.Pause();
    }

   void OnTriggerEnter()
    {
      
       alert.Play();
    }

    public void OnMusic()
    {
        alert.Play();
    }

    public void OffMusic()
    {
        alert.Stop();
    }
}
