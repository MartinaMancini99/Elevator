using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityStandardAssets.Character.FirstPerson;
using TMPro;

public class SceltaPiano : MonoBehaviour
{
    public AudioSource button;
    //public AudioSource clear;
    public AudioSource wrong;
    public AudioSource correct;
    //public AudioSource timer;

    [SerializeField] private TMP_Text Ans;
    private string Answer5 = "5";

    private string Answer1 = "1";
    private string Answer2 = "2";
    private string Answer3 = "3";
    private string Answer4 = "4";

    public void Number(int number)
    {
        Ans.text += number.ToString();
        button.Play();
        //timer.Play();
    }

    public void Execute()
    {
        if(Ans.text == Answer1 || Ans.text == Answer2 || Ans.text == Answer3 || Ans.text == Answer4 || Ans.text == Answer5)
        { 
            correct.Play();
            Ans.text = "THANK YOU";
          //  timer.Pause();
        
          
        }
        else
        {
            wrong.Play();
            Ans.text = "INCORRECT ANSWER";
            
        }
    }

   // public void Clear()
   // {
   //     {
    //        clear.Play();
   //         Ans.text="";
    //    }
    //}
}

