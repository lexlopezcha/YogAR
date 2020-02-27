using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARCameraController : MonoBehaviour
{

    WebCamDevice[] devices;

    public WebCamTexture mCamera = null;
    public GameObject plane; // this is the object where i am going to show the camera

    // Use this for initialization
    void Start()
    {
        devices = WebCamTexture.devices;

        plane = GameObject.FindWithTag("Player");

        mCamera = new WebCamTexture(Screen.width, Screen.height);
        mCamera.deviceName = devices[0].name;  // Front camera is at Index 1 and Back Camera is at Index 0
        plane.GetComponent<Renderer>().material.mainTexture = mCamera;
        mCamera.Play();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
