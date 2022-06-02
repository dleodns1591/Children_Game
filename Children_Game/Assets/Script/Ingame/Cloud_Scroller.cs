using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud_Scroller : MonoBehaviour
{
    [Header("Ÿ��")]
    public Transform Target;
    [Header("��ũ�� ����")]
    public float ScrollRange = 0f;
    [Header("�ӵ�")]
    public float Move_Speed = 0f;
    [Header("����")]
    public Vector3 Move_Direction = Vector3.left;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Move_Direction * Move_Speed * Time.deltaTime;
        
        if (transform.position.x <= -ScrollRange)
        {
            transform.position = Target.position + Vector3.right * ScrollRange;
        }
    }
}
