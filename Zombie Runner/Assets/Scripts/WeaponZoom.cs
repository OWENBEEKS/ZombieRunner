using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float normalFOV = 60f;
    [SerializeField] float zoomedFOV = 35f;

    bool zoomedInToggle = false;

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsCamera.fieldOfView = zoomedFOV;
            }
            else
            {
            zoomedInToggle = false;
            fpsCamera.fieldOfView = normalFOV;
            }
        }
    }
}

