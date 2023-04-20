
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityStandardAssets.Character.FirstPerson;
using TMPro;

public class SceltaPiano : MonoBehaviour
{
    public AudioSource button;
    public AudioSource clear;
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
        
    }

  


     public void Execute()
    {
        if(Ans.text == Answer1 )
        { 
            correct.Play();
            Ans.text = "THANK YOU";
          //  timer.Pause();
        
          
        }else if(Ans.text== Answer2)
        {
             correct.Play();
            Ans.text = "THANK YOU";
        } else if(Ans.text == Answer3)
        {
             correct.Play();
            Ans.text = "THANK YOU";
        } else if(Ans.text == Answer4)
        {
             correct.Play();
            Ans.text = "THANK YOU";
        } else if(Ans.text == Answer5)
        {
             correct.Play();
            Ans.text = "THANK YOU";
        }
        
        else
        {
            wrong.Play();
            Ans.text = "NOT AVAILABLE";
            
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


