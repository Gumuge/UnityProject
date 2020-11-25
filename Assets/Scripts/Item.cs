using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    public float RotateSpeed;
    
    // Update is called once per frame
   
    void Update()
    {
        transform.Rotate(Vector3.right * RotateSpeed * Time.deltaTime, Space.World); // 매개변수 기준으로 회전  space를 통해 월드가 기준인지 로컬이 기준인지 결정
    }
   
}
