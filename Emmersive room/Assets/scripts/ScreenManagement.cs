using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManagement : MonoBehaviour
{
    void Start ()
    {
        Debug.Log ("displays connected: " + Display.displays.Length);
    
        for (int i = 1; i < Display.displays.Length; i++)
            {
                Display.displays[i].Activate();
            }
    }
    
    void Update()
    {

    }
}
