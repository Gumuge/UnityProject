using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component : MonoBehaviour
{
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>(); // Rigidbody Component를 가져옴
        //rigid.AddForce(Vector3.up * 5, ForceMode.Impulse); //해당 방향과 크기로 힘을 줌
                                                    //ForceMode = 힘을 주는 방식
    }

    // Update is called once per frame
    void FixedUpdate()// RigidBody 관련은 여기에 작성 권장 (물리연산)
    {
      //  rigid.velocity = new Vector3(2, 3, 4);// 현재 이동속도
      if(Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
            Debug.Log(rigid.velocity);
        }

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);
        rigid.AddTorque(Vector3.up);//해당 지점을 기준으로 회전함
    }

    private void OnTriggerStay(Collider other)//콜라이더가 충돌중 일 때
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }
}
