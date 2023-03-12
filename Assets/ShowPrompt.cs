using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Get access to unitys UI system
using UnityEngine.UI;

public class ShowPrompt : MonoBehaviour
{
    //The Canvas thet says "Press the correct floor"
    public Canvas EPromptCanvas;

    void onTriggerEnter(Collider TheThingEnteringTheTrigger)
    {
        if(TheThingEnteringTheTrigger.tag == "Player")
        {
            Debug.Log("Player is by lift button panel");
            //Show the 9 Prompt Canvas
            EPromptCanvas.enabled = true;
        }
    }

    void onTriggerExit(Collider TheThingLeaving)
    {
        if(TheThingLeaving.tag == "Player")
        {
            Debug.Log("The player has left the lift button panel");
            //Hide the 9 prompt canvas
            EPromptCanvas.enabled = false;
        }

    }
   
}
