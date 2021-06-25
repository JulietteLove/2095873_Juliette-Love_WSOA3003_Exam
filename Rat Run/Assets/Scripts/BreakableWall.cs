using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWall : MonoBehaviour
{
    public int clickNumber = 0;
    public GameObject MouseOverHighlight;

    public SpriteRenderer spriteRenderer;
    public Sprite Wall;

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            clickNumber += 1;
            
            if (clickNumber == 1)
            {
                spriteRenderer.sprite = sprite2;
            }
            
            if (clickNumber == 2)
            {
                spriteRenderer.sprite = sprite3;
            }
            
            if (clickNumber == 3)
            {
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
