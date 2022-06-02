using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud_Scroller : MonoBehaviour
{
    [Header("타겟")]
    public Transform Target;
    [Header("스크롤 범위")]
    public float ScrollRange = 0f;
    [Header("속도")]
    public float Move_Speed = 0f;
    [Header("방향")]
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
