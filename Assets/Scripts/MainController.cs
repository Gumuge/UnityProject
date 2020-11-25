using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    void Start()
    {
        Vector3 vec = new Vector3(5, 0, 0);// 3차원 벡터 x, y , z 순
        transform.Translate(vec);//이미 초기화 완료된 Transform 변수  Translate = 벡터값을 현재위치에 더하는 함수
       
    }
    void Update()
    {
        /*if (Input.anyKeyDown)//아무 입력을 최초로 받을 때 true 반환
            Debug.Log("아무키가 입력되었습니다");
        if (Input.anyKey)//아무 입력을 받을 때(HOLD 포함) true 반환
            Debug.Log("아무키가 입력되었습니다");
        //각 입력 함수는 3가지 행동으로 구분, Down: 눌렀을 때, Stay: 누르고 있을 때, Up: 눌렀다 뗐을 때
        if (Input.GetKeyDown(KeyCode.Return))// GetKey: 키보드 버튼 입력을 받으면 true
            Debug.Log("구입완료");
        if (Input.GetKey(KeyCode.LeftArrow))// GetKey: 키보드 버튼 입력을 받으면 true
            Debug.Log("왼쪽으로 이동 중");
        if (Input.GetKeyUp(KeyCode.RightArrow))// GetKey: 키보드 버튼 입력을 받으면 true
            Debug.Log("오른쪽 이동이 멈춤");
        if (Input.GetMouseButtonDown(0))//마우스 입력시 true반환 0 = 왼쪽버튼 1 = 오른쪽 버튼
            Debug.Log("발사");
        if (Input.GetMouseButton(0))
            Debug.Log("차징");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("차지샷");
        if (Input.GetButtonDown("Jump")) //input 버튼 입력받으면 true
            Debug.Log("점프");
        if (Input.GetButton("Jump")) 
            Debug.Log("점프차징");
        if (Input.GetButtonUp("Jump")) 
            Debug.Log("차지점프");
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동중" + Input.GetAxis("Horizontal"));
            //수평 수직 버튼 입력시 float 반환 가중치 존재 Raw를 붙일시 가중치 X
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동중" + Input.GetAxisRaw("Vertical"));
            //수평 수직 버튼 입력시 float 반환 가중치 존재 Raw를 붙일시 가중치 X
        }*/
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(vec);

        /*Time.deltaTime = 프레임이 많으면 작고 프레임이 적으면 커짐 때문에 업데이트의 반복값을 늘 일정하게 유지
            transform.Translate(Vec * Time.deltaTime)
            Vector3.Lerp(Vec1, Vector2, t*Time.deltaTime)*/
    }
}
