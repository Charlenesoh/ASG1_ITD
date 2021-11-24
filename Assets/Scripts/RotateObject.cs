using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{ 
    private Vector3 rotation;
    [SerializeField] private float speed;
    public GameObject Object;

    // Another alternative to code for using keyboard keys instead of buttons
     /*void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rotation = Vector3.up;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            rotation = Vector3.down;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            rotation = Vector3.left;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rotation = Vector3.right;
        }

        else rotation = Vector3.zero;

        transform.Rotate(rotation * speed * Time.deltaTime);
    }*/

    // Button functions to move object upwards
    public void Vertical()
    {
        rotation = Vector3.up;
        Object.transform.Rotate(rotation * speed * Time.deltaTime);
    }

    // Button functions to move object sideways
    public void Horizontal()
    {
        rotation = Vector3.left;
        Object.transform.Rotate(rotation * speed * Time.deltaTime);
    }

}
