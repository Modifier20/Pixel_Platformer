using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControllerSettings : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetQuality()
    {
        SetScreenResolution();
    }

    void SetScreenResolution()
    {
        // Getting the name of what we pressed.
        string index = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        switch (index)
        {
            case "0":
                Screen.SetResolution(960, 540, false);
                Debug.Log("Screen Resolution Set To: 960 x 540, false");
                break;
            case "1":
                Screen.SetResolution(1920, 1080, false);
                Debug.Log("Screen Resolution Set To: 1920 x 1080, false");
                break;
            case "2":
                Screen.SetResolution(1920, 1080, true);
                Debug.Log("Screen Resolution Set To: 1920 x 1080, true");
                break;
            case "3":
                Screen.SetResolution(4096, 2304, true);
                Debug.Log("Screen Resolution Set To: 4096 x 2304, true");
                break;
        }
    }
}
