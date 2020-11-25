using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()//게임 오브젝트 생성할 때 최초 실행
    {
        Debug.Log("데이터가 준비되었습니다");
    }
    void OnEnable()//게임 오브젝트가 활성화 되었을 때
    {
        Debug.Log("접속하였습니다");
    }
    void Start()// 업데이트 시작 전 최초 실행
    {
        Debug.Log("플레이어가 준비를 마쳤습니다");
    }
    void FixedUpdate()// 물리연산 업데이트(물리연산 전 실행)
    {
        Debug.Log("이동합니다");
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("공격합니다");
    }
    void LateUpdate()//모든 업데이트가 실행되고 난 후
    {
        Debug.Log("결과를 출력합니다");
    }
    void OnDisable()//게임 오브젝트가 비활성화 되었을 때
    {
        Debug.Log("종료합니다");
    }
    void OnDestroy()//게임 오브젝트가 삭제될 떄
    {
        Debug.Log("데이터가 해체됩니다.");
    }
}
