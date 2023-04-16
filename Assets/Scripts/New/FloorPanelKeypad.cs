using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class FloorPanelKeypad : MonoBehaviour
{

    public AudioSource panelButton;
   // public AudioSource clear;
    public AudioSource panelButtonWrong;
    public AudioSource panelButtonCorrect;
    //public AudioSource timer;

    [SerializeField] private TMP_Text PanelAns;
    private string PanelAnswer = "9";

    public void PanelNumber(int panelnumber)
    {
        
        PanelAns.text += panelnumber.ToString();
        panelButton.Play();
    }

    public void PanelExecute()
    {
        if(PanelAns.text == PanelAnswer)
        {
           panelButtonCorrect.Play();
           PanelAns.text = "CORRECT";
           SceneManager.LoadScene(2);

        }
        else
        {
            panelButtonWrong.Play();
            PanelAns.text = "INCORRECT";
        }
    }



   
}
