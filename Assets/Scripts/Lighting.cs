using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{

    //Reference the spotlight marker
    public Transform lightMarker;

    //Create a variable for pointing the light
    Transform spotlightATransform;

    // Start is called before the first frame update
    void Start()
    {
        
        //Make a GameObject
        GameObject SpotlightA = new GameObject("SpotlightA");

        //Connect the light to look at thev mark
        spotlightATransform = SpotlightA.transform;

        //Add the light component to our GameObject
        Light spotlightA = SpotlightA.AddComponent<Light>();

        //Change the light from a point to a spotlight
        spotlightA.type = LightType.Spot;

        //Create a light position variable
        Vector3 spotlightAPosition;

        //Choose the position
        spotlightAPosition = new Vector3(2, 5, 1);

        //Change the position
        spotlightA.transform.position = spotlightAPosition;

    }

    // Update is called once per frame
    void Update()
    {
        spotlightATransform.LookAt(lightMarker);
        
    }
}
