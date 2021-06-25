using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailFollowScript : MonoBehaviour
{
    public GameObject target;
    public SpriteRenderer sr;
    public bool flipX;

    private void FixedUpdate()
    {
        RatMovement ratMovement = GameObject.FindWithTag("Rat").GetComponent<RatMovement>();

        if (ratMovement.facingRight == false)
        {
            transform.position = new Vector2(target.transform.position.x + 0.6f, target.transform.position.y);
        }
        else if (ratMovement.facingRight == true)
        {
            transform.position = new Vector2(target.transform.position.x - 0.55f, target.transform.position.y);
        }
    }
}
