using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    
    void Start()
    {
        Destroy(gameObject, 1f) ;
    }

    
    private void OneMouseDown()
    {
        GameControl.score += 10;
        GameControl.targetsHit += 1;
        Destroy(gameObject);
    }
}
