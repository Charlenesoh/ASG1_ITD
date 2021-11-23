using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARToggle : MonoBehaviour
{
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
