using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWall : MonoBehaviour
{
    public int clickNumber = 0;
    
    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            clickNumber += 1;

            if (clickNumber == 3)
            {
                Destroy(gameObject);
            }
        }
    }
}
