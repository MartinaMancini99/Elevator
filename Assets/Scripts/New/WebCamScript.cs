using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class WebCamScript : MonoBehaviour
{
    //static WebCamTexture backCam;

    private Texture defaultBackground;
    private WebCamTexture backCam;
   // private bool camAvailable;
    
    //this is for display the webcam
    public RawImage background;
   
    public AspectRatioFitter fit;

    private void Start()
    {
        defaultBackground = background.texture;

     //   WebCamDevice[] devices = WebCamTexture.devices;

   // if(devices.Lenght == 0)
   // {
   //     Debug.Log("No Camera detected");
   //     camAvailable = false;
   //     return;
   // }

  //  for(int i = 0; i<devices.Lenght; i++)
  //  {
   //     if(!devices[i].isFrontFacing)
       // {
   //         backCam = new WebCamTexture(devices[i].name, Screen.width, Screen.height);
   //     }
  //  }

  //  if(backCam == null)
  //  {
    //    Debug.Log("Unable to find back camera");
    //    return;
 //   }


   // backCam.Play(); 
   // background.texture = backCam;

   // camAvailable = true;
        if(backCam == null)
        backCam = new WebCamTexture();
        
        //GetComponent<Renderer>().material.mainTexture = backCam;

        if(!backCam.isPlaying)
            backCam.Play();
             background.texture = backCam;
    
    }

   // private void Update()
    //{

   // }

   private void Update()
   {
    float ratio = (float)backCam.width / (float)backCam.height;
    fit.aspectRatio = ratio;

    float scaleY =backCam.videoVerticallyMirrored ? -1f: 1f;
    background.rectTransform.localScale = new Vector3(1f, scaleY, 1f);

    int orient = -backCam.videoRotationAngle;
    background.rectTransform.localEulerAngles = new Vector3( 0, 0, orient);
   }
}
