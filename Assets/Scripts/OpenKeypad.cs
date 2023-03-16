using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenKeypad : MonoBehaviour
{
    public GameObject keypadOB;
    public GameObject keypadText;
    public GameObject quizImage;

    public bool inReach;

    void Start()
    {
        inReach = false;

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Reach")
        {
            inReach = true;
            keypadText.SetActive(true);
            //quizImage.SetActive(false);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Reach")
        {
            inReach = false;
            keypadText.SetActive(false);
            quizImage.SetActive(true);
        }
    }

  void Update()
  {
        if(Input.GetButtonDown("Interact") && inReach)
       { 
           keypadOB.SetActive(true);
           quizImage.SetActive(true);
           keypadText.SetActive(true);
        }

   }
}
