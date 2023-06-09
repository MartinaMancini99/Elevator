using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveSceneOnKeyPressed : MonoBehaviour
{
    [SerializeField] private string newLevel;
    [SerializeField] private GameObject uiElement;

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            uiElement.SetActive(true);

            if(Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(newLevel);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            uiElement.SetActive(false);
        }
    }
}
