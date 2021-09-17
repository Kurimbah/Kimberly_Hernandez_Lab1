using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnMainMenuButton : MonoBehaviour
{
    //link to the Main Camera's Transform
    public Transform mainCam;

    //float holding the main camera's new X position
    public float newCamX;

    //float holding the main camera's new Y position
    public float newCamY;

    //Link to camera's audio source
    public AudioSource camAudio;

    //Link to clip to play for the button 
    public AudioClip buttonSound;

    //Custom method called by the button click event
    public void ReturnToMainMenu()
    {
        //Set the main camera's X and Y position to the newCamX and newCamY values
        //Leave the Z position as it is -> -950
        mainCam.position = new Vector3(newCamX, newCamY, mainCam.position.z);

        //use the camera's audio source to play the button sound audio clip at 1/4 volume
        camAudio.PlayOneShot(buttonSound, 0.25f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
