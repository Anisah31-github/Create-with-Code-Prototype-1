using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera2 : MonoBehaviour
{
    
    public Camera player2Cam;
    public Camera hoodCamera;

    private int cameraState = 0;

    // disable FPS camera and enable overhead camera.
    public void ShowHoodCameraView() {
        player2Cam.enabled = false;
        hoodCamera.enabled = true;
    }
    
    // enable FPS camera and disable overhead camera.
    public void ShowPlayer2CamView() {
        player2Cam.enabled = true;
        hoodCamera.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        ShowPlayer2CamView();
    }

    // Update is called once per frame
    void Update()
    {
        // change views by pressing the left ctrl button
        if (Input.GetButtonDown("Fire3"))
        {
            if (cameraState == 0) {
                ShowPlayer2CamView();
            }
            else {
                ShowHoodCameraView();
            }
            // change the camera state
            cameraState^=1;
        }
    }
}
