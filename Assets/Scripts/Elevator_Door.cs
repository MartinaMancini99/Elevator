using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator_Door : MonoBehaviour
{
    public Animator anim;
    public Transform player;
    public Transform door;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame


    void Update()
    {
          float distance = Vector3.Distance(player.position, door.position);

        if(distance < 5 )
        
        {
            
            anim.SetBool("Near", true);
            
        }
        else
        {
            anim.SetBool("Near", false);
        }
    
    }
}
