using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Get Access to Unity UI features
using UnityEngine.UI;
using TMPro;

public class ShowPuzzle : MonoBehaviour
{
    //Canvas
    public Canvas EPromptCanvas;
    public Canvas PuzzleCanvas;

    //Text
    public TextMeshProUGUI UserInputText;
    public string SecretCode = "9";

    //Character
    //public CharacterController PlayerController;

    //Reference to Change on the next scene

    //Secret code is not yet entered
    public bool SecretCodeEntered = false;

    public void Update()
    {
        if(UserInputText.text == SecretCode && SecretCodeEntered==false)
        {
            Debug.Log("The Secret Code is Correct!");
            SecretCodeEntered = true;
           EPromptCanvas.enabled = false;
           PuzzleCanvas.enabled = false;

           
        }
    }



    void OnTriggerStay(Collider TheThingInsideTheTrigger)
    {
        if(TheThingInsideTheTrigger.tag == "Player" && SecretCodeEntered == false)
        {
            //check if they press E
            if(Input.GetKey(KeyCode.E))
            {
                //show puzzle canvas
                PuzzleCanvas.enabled = true;

                //Hide 9 Prompt
                EPromptCanvas.enabled = false;

                //stop the player moving
                //PlayerController.enabled = false;

                //give the player access to the cursor
                //Cursor.lockState = CursorLockMode.None;
            }
            else if(Input.GetKey(KeyCode.Escape))
            {
                ExitButton();
            }
        }
    }

    public void ExitButton()
    {
        PuzzleCanvas.enabled = false;
        EPromptCanvas.enabled = true;

        //Enable playerMovement
       // PlayerController.enabled = true;

        //Lock the Cursor
        //Cursor.lockState = CursorLockMode.Locked;

    }
}
