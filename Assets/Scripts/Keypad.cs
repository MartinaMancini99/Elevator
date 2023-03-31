using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityStandardAssets.Character.FirstPerson;
using TMPro;

public class Keypad : MonoBehaviour
{
    public AudioSource button;
    public AudioSource clear;
    public AudioSource wrong;
    public AudioSource correct;
    //public AudioSource timer;

    [SerializeField] private TMP_Text Ans;
    private string Answer = "9";

    public void Number(int number)
    {
        Ans.text += number.ToString();
        button.Play();
        //timer.Play();
    }

    public void Execute()
    {
        if(Ans.text == Answer)
        { 
            correct.Play();
            Ans.text = "CORRECT ANSWER";
          //  timer.Pause();
        
          
        }
        else
        {
            wrong.Play();
            Ans.text = "INCORRECT ANSWER";
            
        }
    }

    public void Clear()
    {
        {
            clear.Play();
            Ans.text="";
        }
    }
}
