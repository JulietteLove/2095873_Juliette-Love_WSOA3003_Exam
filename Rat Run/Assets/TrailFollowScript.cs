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

        if (ratMovement.facingRight == true)
        {

        }
        else if (ratMovement.facingRight == false)
        {
            Debug.Log("Rat is facing left");
            transform.position = new Vector3(target.transform.position.x - 30f, target.transform.position.y, target.transform.position.z);
        }
        
    }
}
