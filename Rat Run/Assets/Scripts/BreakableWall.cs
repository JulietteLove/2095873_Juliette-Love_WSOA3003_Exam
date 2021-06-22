using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWall : MonoBehaviour
{
    public int clickNumber = 0;
    public GameObject MouseOverHighlight;

    public SpriteRenderer spriteRenderer;
    public Sprite Wall;

    
    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            clickNumber += 1;
            if (clickNumber == 1)
            {
                spriteRenderer.color = new Color(0.4528302f, 0.4528302f, 0.4528302f, 1);
                Debug.Log("One");
            }
            if (clickNumber == 2)
            {
                spriteRenderer.color = new Color(0.2641509f, 0.2641509f, 0.2641509f, 1);
                Debug.Log("Two");
            }
            if (clickNumber == 3)
            {
                Debug.Log("Three");
                Destroy(gameObject);
                RatMovement ratMovement = GameObject.FindWithTag("Rat").GetComponent<RatMovement>();
                ratMovement.maxSpeed = 3f;
            }
        }
        
        MouseOverHighlight.SetActive(true);
    }
    
    private void OnMouseExit()
    {
        MouseOverHighlight.SetActive(false);
    }
}
