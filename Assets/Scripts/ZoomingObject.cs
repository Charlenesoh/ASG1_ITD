using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomingObject : MonoBehaviour
{
    public GameObject Object;

    public float Scale = 0.1f;


    public void OnPressZoomIn()
    {
        Object.transform.localScale += new Vector3(Scale, Scale, Scale);
    }
    
    public void OnPressZoomOut()
    {
        Object.transform.localScale -= new Vector3(Scale, Scale, Scale);
    }
}
