using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemieMovement : MonoBehaviour
{
    Vector3 tempPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            tempPos = transform.position;
            tempPos.x -= 1f;
            transform.position=tempPos;
         
        
    }
}
