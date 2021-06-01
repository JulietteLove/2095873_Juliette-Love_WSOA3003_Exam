using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vents : MonoBehaviour
{
    private bool ventIsOn = true;
    
    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (ventIsOn == true)
            {
                GetComponent<AreaEffector2D>().enabled = false;
                ventIsOn = false;
                Debug.Log("Vent is on");
            }
            else if (ventIsOn == false)
            {
                GetComponent<AreaEffector2D>().enabled = true;
                ventIsOn = true;
                Debug.Log("Vent is off");
            }
        }
    }
}
