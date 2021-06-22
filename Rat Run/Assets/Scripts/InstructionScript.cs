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

    public void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        
        if (sceneName == "IntroductionLevel")
        {
            Vents vents = GameObject.FindWithTag("Vent").GetComponent<Vents>();
            vents.canClick = false;
        }
    }

    public void click()
    {
        Instructions1.SetActive(false);
        Instructions2.SetActive(false);
        Instructions3.SetActive(false);
        Debug.Log("HasClicked");
    }
}
