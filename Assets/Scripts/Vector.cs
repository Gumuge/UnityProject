using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    Vector3 target = new Vector3(8, 1.2f, 0);
    Vector3 velo = Vector3.zero;
    // Update is called once per frame
    void Update()
    {
        //MoveTowards = 목표지점까지 이동
        //transform.position = Vector3.MoveTowards(transform.position, target, 1f); // 현재위치, 목표위치, 걸리는시간

        //SmoothDamp = 부드러운 감속으로 이동
        // transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 1f); // 현재위치, 목표위치, 참조속도, 걸리는시간

        //Lerp = Smooth보다 감속시간이 긺(선형 보간)
        //transform.position = Vector3.Lerp(transform.position, target, 0.05f); // 현재위치, 목표위치, 걸리는시간

        //SLerp = 호를 그리며 이동(구면 선형 보간)
        transform.position = Vector3.Slerp(transform.position, target, 0.05f); // 현재위치, 목표위치, 걸리는시간
    }
}
