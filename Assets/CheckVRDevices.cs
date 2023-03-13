using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVRDevices : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [System.Obsolete]
    void Update()
    {
        var inputDevices = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevices(inputDevices);

        var desireCharracteristics = UnityEngine.XR.InputDeviceCharacteristics.HeldInHand| UnityEngine.XR.InputDeviceCharacteristics.Left| UnityEngine.XR.InputDeviceCharacteristics.Controller;
        UnityEngine.XR.InputDevices.GetDevicesWithCharacteristics(desireCharracteristics, inputDevices);
        foreach(var device in inputDevices){
            if(device.name != "Head Tracking - OpenXR"){
            //Debug.Log(string.Format("Device found with name '{0}' and role '{1}'", device.name, device.role.ToString()));

            }
            
        }
    }
}
