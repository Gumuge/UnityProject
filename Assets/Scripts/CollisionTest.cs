using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();// 오브젝트 재질 접근
        mat = mesh.material;
        mat.color = new Color(1, 1, 1);
    }

    private void OnCollisionEnter(Collision collision)//물리적 충돌이 발생할 때 호출되는 함수
    {
        if(collision.gameObject.name == "MainBall")
             mat.color = new Color(0, 0, 0);
    }
    
    /*private void OnCollisionStay(Collision collision)//충돌중 일 때
    {

    }*/
    private void OnCollisionExit(Collision collision)//물리적 충돌이 끝났을 때 
    {
        if (collision.gameObject.name == "MainBall")
            mat.color = new Color(2, 2, 2);
    }
}
