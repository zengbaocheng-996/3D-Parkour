using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    // ����һ���������
    GameObject endUI;
    private void Start()
    {
        // ͨ�������ڳ����е��������ҵ��������
        endUI = GameObject.Find("EndUI");
        // �ڳ����������������
        endUI.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name=="Player")
        {
            Debug.Log("����");
            // �ڳ�������ʾ�������
            endUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
