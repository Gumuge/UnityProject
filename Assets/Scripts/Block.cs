using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public float MoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * MoveSpeed * Time.deltaTime;
        if(transform.position.x <= -4.4f)
        {
            transform.position = new Vector3(4.25f, 1.5f, -18.1f);
        }
    }
  
}
