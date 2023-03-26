using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowFloorPanelCanvas : MonoBehaviour
{

     //Canvas
    public Canvas EPromptCanvas;
    public Canvas FloorPanelCanvas;

   void OnTriggerStay(Collider TheThingInsideTheTrigger)
    {
        if(TheThingInsideTheTrigger.tag == "Player" )
        {
            //check if they press E
            if(Input.GetKey(KeyCode.E))
            {
                //show puzzle canvas
                FloorPanelCanvas.enabled = true;

                //Hide Prompt
                EPromptCanvas.enabled = false;

                //stop the player moving
                //PlayerController.enabled = false;

                //give the player access to the cursor
                //Cursor.lockState = CursorLockMode.None;
            }
        }
    }    
}
