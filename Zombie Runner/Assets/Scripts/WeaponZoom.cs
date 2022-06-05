using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera; 
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float normalFOV = 60f;
    [SerializeField] float zoomedFOV = 35f;
    [SerializeField] float normalSensitivity = 2f;
    [SerializeField] float zoomedSensitivity = 1f;
    bool zoomedInToggle = false;

    private void OnDisable()
    {
        ZoomOut();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomedInToggle == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    private void ZoomIn()
    {
        zoomedInToggle = true;
        fpsCamera.fieldOfView = zoomedFOV;
        fpsController.mouseLook.XSensitivity = zoomedSensitivity;
        fpsController.mouseLook.YSensitivity = zoomedSensitivity;
    }
    private void ZoomOut()
    {
        zoomedInToggle = false;
        fpsCamera.fieldOfView = normalFOV;
        fpsController.mouseLook.XSensitivity = normalSensitivity;
        fpsController.mouseLook.YSensitivity = normalSensitivity;
    }
}

