using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignToText_Launcher : MonoBehaviour
{
    public Text tx;
    
    void Start()
    {
        // Initialization code
    }

    void Update()
    {
        // Update logic here
    }

    public void LaunchTargetApp()
     {
        
             Application.OpenURL("http://smarttouch-eg.com/must");
     }
        
    
}
