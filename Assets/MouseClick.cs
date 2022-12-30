using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

using UnityEngine.SceneManagement;

public class MouseClick : MonoBehaviour
{
    void Update()
    {
/*
        if (Input.GetMouseButtonDown(0))
        {
            ToggleVR();
        } */
    }

    void ToggleVR()
    {
/*
        if (UnityEngine.XR.XRSettings.loadedDeviceName == "cardboard")
        {
            StartCoroutine(LoadDevice("None"));
        }
        else
        {
            StartCoroutine(LoadDevice("cardboard"));
        }
        */
    }
/*
    IEnumerator LoadDevice(string newDevice)
    {
        UnityEngine.XR.XRSettings.LoadDeviceByName(newDevice);
        yield return null;
        UnityEngine.XR.XRSettings.enabled = true;
    }
    */
    private void OnMouseDown()
    {
        SceneManager.LoadScene("VrSurgeryScene");
    }
}
