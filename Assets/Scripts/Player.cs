using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float speed;
    public float turnspeed;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
            return;
        }
        float x = Input.GetAxis("Horizontal");
        transform.Translate(x * turnspeed * Time.deltaTime, 0, speed * Time.deltaTime);
        // һ��С��λ�ó������ܵ��ķ�Χ��ֱ������
        if (transform.position.x < -4||transform.position.x>4)
        {
            transform.Translate(0, -10 * Time.deltaTime, 0);
        }
        // ����һ������֮����Ϸ����
        if(transform.position.y<-20)
        {
            Time.timeScale = 0;
        }
        Transform c = Camera.main.transform;
        Quaternion cur = c.rotation;
        Quaternion target = cur * Quaternion.Euler(0, 0, x * 0.5f);
        Camera.main.transform.rotation = Quaternion.Slerp(cur, target, 0.5f);
    }
}
