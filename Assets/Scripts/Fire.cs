using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += -Vector3.forward * speed;
        if (transform.position.z <= -25)
            transform.position = new Vector3(0, 2.0f, -4.4f);
       
    }
}
