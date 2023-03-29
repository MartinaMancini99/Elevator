using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Get access to unitys UI system
using UnityEngine.UI;

public class ShowInteraction : MonoBehaviour
{
    //The Canvas that says "Press E to interact
    public Canvas EPromptCanvas;

    //A reference to the ShowPuzzle Script
    public ShowPuzzle PuzzleScript;


    void OnTriggerEnter(Collider TheThingEnteringTheTrigger)
    {
        if(TheThingEnteringTheTrigger.tag == "Player" )
        {
            Debug.Log("Player is by the lift button ");

            //Show the E propmpt canvas
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
