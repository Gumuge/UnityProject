using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ManagerLogic : MonoBehaviour
{
    public int TotalCount;
    public int stage;
    public Text StageText;

    void Awake()
    {
        StageText.text = stage.ToString();
    }
   


}
