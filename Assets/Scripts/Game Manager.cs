using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject FirstPersonCamera;
    public GameObject ThirdPersonCamera;

    private bool isFirstPerson = true;

    void Start()
    {
        ToggleCameras(); // Start with the initial camera setup
    }

    void Update()
    {
        // Check for input to toggle cameras
        if (Input.GetKeyDown(KeyCode.T))
        {
            ToggleCameras();
        }
    }

    void ToggleCameras()
    {
        isFirstPerson = !isFirstPerson;
        FirstPersonCamera.SetActive(isFirstPerson);
        ThirdPersonCamera.SetActive(!isFirstPerson);
    }
}
