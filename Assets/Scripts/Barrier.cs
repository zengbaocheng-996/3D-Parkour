using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // 防止其他物体与障碍物的碰撞被检测，我们只需要障碍物与小球的碰撞被检测到
        if (other.name == "Player")
        {
            Time.timeScale = 0;
        }
    }
}
