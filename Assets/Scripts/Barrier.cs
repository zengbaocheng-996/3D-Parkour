using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // ��ֹ�����������ϰ������ײ����⣬����ֻ��Ҫ�ϰ�����С�����ײ����⵽
        if (other.name == "Player")
        {
            Time.timeScale = 0;
        }
    }
}
