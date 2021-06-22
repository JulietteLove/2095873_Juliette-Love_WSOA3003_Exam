using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vents : MonoBehaviour
{
    public bool ventIsOn = true;
    public GameObject MouseOverHighlight;
    public GameObject ParticleSystem;

    public bool canClick = true;
    public bool canActivate = true;

    void Update()
    {
        if (ventIsOn == true)
        {
            GetComponent<AreaEffector2D>().enabled = true;
            ParticleSystem.SetActive(true);
        }
        else if (ventIsOn == false)
        {
            GetComponent<AreaEffector2D>().enabled = false;
            ParticleSystem.SetActive(false);
        }
    }

    private void OnMouseOver()
    {            
        RatMovement ratMovement = GameObject.FindWithTag("Rat").GetComponent<RatMovement>();

        if (Input.GetKeyDown(KeyCode.Mouse0) && canClick == true)
        {
            if (ventIsOn == false)
            {
                ventIsOn = true;
            }
            else if (ventIsOn == true)
            {
                ventIsOn = false;
            }

            ratMovement.maxSpeed = 3f;
        }

        MouseOverHighlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        MouseOverHighlight.SetActive(false);
    }
}
