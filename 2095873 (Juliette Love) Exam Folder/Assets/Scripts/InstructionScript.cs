using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionScript : MonoBehaviour
{
    public GameObject Instructions1;
    public GameObject Instructions2;
    public GameObject Instructions3;
    
    public GameObject Hitbox1;
    public GameObject Hitbox2;
    public GameObject Hitbox3;

    public void click()
    {
        Vents vents = GameObject.FindWithTag("Vent").GetComponent<Vents>();
        vents.canClick = true;

        RatMovement ratMovement = GameObject.FindWithTag("Rat").GetComponent<RatMovement>();
        ratMovement.maxSpeed = 3f;

        Instructions1.SetActive(false);
        Instructions2.SetActive(false);
        Instructions3.SetActive(false);
    }
}
