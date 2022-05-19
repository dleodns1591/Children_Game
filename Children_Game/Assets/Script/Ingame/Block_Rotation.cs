using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Rotation : MonoBehaviour
{
    // 블럭 회전속도
    private float BlockRotation_Speed = 3f;

    void Start()
    {

    }

    void Update()
    {
        BlockRotaion();
    }

    public void BlockRotaion()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0f, -Input.GetAxis("Mouse X") * BlockRotation_Speed, 0f, Space.World);
            transform.Rotate(Input.GetAxis("Mouse Y") * BlockRotation_Speed, 0f, 0f);
        }
    }
}
