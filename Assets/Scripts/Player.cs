using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //SceneMangament클래스 이용을 위한 작업

public class Player : MonoBehaviour
{
    Rigidbody rigid;
    public float JumpPower;
    public int ItemCount;
    bool IsJump;
    AudioSource audio;
    public ManagerLogic Manager;
    
    
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        IsJump = false;
        audio = GetComponent<AudioSource>();
        
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if (IsJump != true)
        {
            IsJump = true;
            rigid.AddForce(new Vector3(0, JumpPower, 0), ForceMode.Impulse);
        }
        rigid.AddForce(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")), ForceMode.Impulse);
        //rigid.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
            IsJump = false;
        else if (collision.gameObject.tag == "JumpBoost")
        {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
            IsJump = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            other.gameObject.SetActive(false); //오브젝트 활성화 함수
            audio.Play();
            ItemCount++;
        }
        else if(other.tag == "Goal")
        {
            if(ItemCount == Manager.TotalCount)
            {
                //Done
                SceneManager.LoadScene("Stage" + (Manager.stage + 1));
                
            }
            else
            {
                //Restart;
                SceneManager.LoadScene("Stage" + Manager.stage);
            }
        }
        else if(other.tag == "Respawn")
        {
            Manager.TotalCount++;
            SceneManager.LoadScene("Stage" + Manager.stage);
        }
        else if (other.tag == "Fire")
        {
            Manager.TotalCount++;
            SceneManager.LoadScene("Stage" + Manager.stage);
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if(other.name == "Cube")
        {
            rigid.AddForce(Vector3.up, ForceMode.Impulse);
        }
    }

}
