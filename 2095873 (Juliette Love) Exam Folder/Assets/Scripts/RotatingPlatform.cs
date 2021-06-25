using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public GameObject rotatingPlatform;
    public GameObject MouseOverHighlight;

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rotatingPlatform.transform.Rotate(Vector3.forward, 90.0f);

            InstructionScript instructionScript = GameObject.FindWithTag("Button").GetComponent<InstructionScript>();
            instructionScript.Hitbox3.SetActive(false);

            RatMovement ratMovement = GameObject.FindWithTag("Rat").GetComponent<RatMovement>();
            ratMovement.maxSpeed = 3f;
        }

        MouseOverHighlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        MouseOverHighlight.SetActive(false);
    }
}
