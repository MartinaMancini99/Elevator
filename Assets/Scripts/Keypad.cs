using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityStandardAssets.Character.FirstPerson;
using TMPro;

public class Keypad : MonoBehaviour
{

    [SerializeField] private TMP_Text Ans;
    private string Answer = "11";

    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if(Ans.text == Answer)
        {
          Ans.text = "CORRECT ANSWER";
        }
        else
        {
            Ans.text = "INCORRECT ANSWER";
        }
    }

    public void Clear()
    {
        {
            Ans.text="";
        }
    }
}
