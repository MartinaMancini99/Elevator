using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Get access to unitys UI system
using UnityEngine.UI;
public class ShowInteraction : MonoBehaviour
{
    public Canvas EPromptCanvas;
    void OnTriggerEnter(Collider TheThingEnteringTheTrigger)
    {
        if(TheThingEnteringTheTrigger.tag == "Player")
        {
            Debug.Log("Player is by the lift button ");
            EPromptCanvas.enabled = true;
        }
    } 

    void OnTriggerExit(Collider TheThingLeaving)
    {
        if(TheThingLeaving.tag == "Player")
        {
            Debug.Log("The player has left the lift button panel");
            //hide the Prompt Canvas
            EPromptCanvas.enabled = false;
        }
    }

}
