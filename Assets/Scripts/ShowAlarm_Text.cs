using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAlarm_Text : MonoBehaviour
{
     public GameObject uiObjectAlarm; 
     public AudioSource alarm;
     void Start()
    {
        uiObjectAlarm.SetActive(false);
        alarm.Pause();
    }

    void OnTriggerEnter()
    {
        uiObjectAlarm.SetActive(true);
        alarm.Play();
    }

   void OnTriggerExit()
   {
    uiObjectAlarm.SetActive(false);
   }
}
