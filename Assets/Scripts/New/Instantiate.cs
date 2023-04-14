using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public Transform spawn;
    public GameObject Prefab;
    public Canvas canvas;

    // Use this for initialization
    void Start()
    {
        Vector3 spawnPosition = transform.position(Prefab); 
            Vector3(Prefab.Position.x, Prefab.position.y, (Prefab.position.z - 55));
        //z-55 because in this way the prefab is actually in front of the canvas
        
        Prefab = Instantiate(Prefab, spawnPosition, Quaternion.identity) as GameObject;
      
    }

    // Update is called once per frame
}
