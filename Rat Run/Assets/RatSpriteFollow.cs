using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatSpriteFollow : MonoBehaviour
{
    public GameObject target;
    private SpriteRenderer sr;
    public bool flipX;
    
    public void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        transform.position = new Vector3(target.transform.position.x - 0.3f, target.transform.position.y, target.transform.position.z);
        RatMovement ratMovement = GameObject.FindWithTag("Rat").GetComponent<RatMovement>();

        if (ratMovement.facingRight == true)
        {
            sr.flipX = false;
        }
        else
        {
            sr.flipX = true;
        }
    }
}
