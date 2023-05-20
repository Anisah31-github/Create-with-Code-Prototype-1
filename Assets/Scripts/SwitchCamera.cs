using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public Camera mainCamera;
    public Camera hoodCamera;

    private int cameraState = 0;

    // disable FPS camera and enable overhead camera.
    public void ShowHoodCameraView() {
        mainCamera.enabled = false;
        hoodCamera.enabled = true;
    }
    
    // enable FPS camera and disable overhead camera.
    public void ShowMainCameraView() {
        mainCamera.enabled = true;
        hoodCamera.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        ShowMainCameraView();
    }

    // Update is called once per frame
    void Update()
    {
        // change views by pressing the left ctrl button
        if (Input.GetButtonDown("Jump"))
        {
            if (cameraState == 0) {
                ShowMainCameraView();
            }
            else {
                ShowHoodCameraView();
            }
            // change the camera state
            cameraState^=1;
        }
    }
}
