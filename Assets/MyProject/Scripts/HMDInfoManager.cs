using UnityEngine;
using System.Collections;
using UnityEngine.XR;

//---------------------------------------------------------------------------------
// Youtube      : https://www.youtube.com/watch?v=UlqdHrfXppo
// Description	: This will check which HMD is available. If not try to use MockHMD.
//---------------------------------------------------------------------------------
public class HMDInfoManager : MonoBehaviour 
{
    //===================
    // Private Variables
    //===================
    [SerializeField] GameObject mockSimulator;
	
    //---------------------------------------------------------------------------------
    // Start is when Script is active
    //---------------------------------------------------------------------------------
    protected void Start() 
    {
        Debug.Log("Is Device Active: " + XRSettings.isDeviceActive);
        Debug.Log("Device Name is : " + XRSettings.loadedDeviceName);

        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No Headset plugged in");
            mockSimulator.SetActive(true);
        }
        else if (XRSettings.isDeviceActive && XRSettings.loadedDeviceName == "MockHMD Display")
        {
            Debug.Log("Using Mock HMD");
            mockSimulator.SetActive(true);
        }
        else
        {
            Debug.Log("We Have a Headset " + XRSettings.loadedDeviceName);
            mockSimulator.SetActive(false);
        }
    }
	
}

