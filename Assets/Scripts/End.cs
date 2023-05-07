using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    // 声明一个物体变量
    GameObject endUI;
    private void Start()
    {
        // 通过物体在场景中的名字来找到这个物体
        endUI = GameObject.Find("EndUI");
        // 在场景中隐藏这个物体
        endUI.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name=="Player")
        {
            Debug.Log("过关");
            // 在场景中显示这个物体
            endUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
