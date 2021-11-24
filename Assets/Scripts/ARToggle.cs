using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARToggle : MonoBehaviour
{
    // toggle AR camera on and off 
    public void Toggling()
    {
        if(VuforiaBehaviour.Instance.enabled)
        {
            VuforiaBehaviour.Instance.enabled = false; 
        }
        else
        {
            VuforiaBehaviour.Instance.enabled = true;
        }
    }
}
