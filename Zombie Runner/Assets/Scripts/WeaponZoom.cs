using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float normalFOV = 60f;
    [SerializeField] float zoomedFOV = 35f;
    [SerializeField] float normalSensitivity = 2f;
    [SerializeField] float zoomedSensitivity = 1f;

    RigidbodyFirstPersonController fpsController;

    bool zoomedInToggle = false;

    private void Start()
    {
        fpsController = GetComponent<RigidbodyFirstPersonController>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsCamera.fieldOfView = zoomedFOV;
                fpsController.mouseLook.XSensitivity = zoomedSensitivity;
                fpsController.mouseLook.YSensitivity = zoomedSensitivity;
            }
            else
            {
                zoomedInToggle = false;
                fpsCamera.fieldOfView = normalFOV;
                fpsController.mouseLook.XSensitivity = normalSensitivity;
                fpsController.mouseLook.YSensitivity = normalSensitivity;
            }
        }
    }
}

