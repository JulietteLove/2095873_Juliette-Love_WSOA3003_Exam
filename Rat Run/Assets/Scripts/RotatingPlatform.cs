using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public GameObject rotatingPlatform;

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rotatingPlatform.transform.Rotate(Vector3.forward, 90.0f);
        }
    }
}
