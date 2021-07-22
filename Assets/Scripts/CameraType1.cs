using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraType1 : MonoBehaviour
{
    // 플레이어로부터 고정된 위치에 존재한다.
    // 플레이어의 회전으로부터 영향을 받지 않는다.

    public Transform playerPos;
    public Vector3 offset;

    float followSpeed = 3;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, playerPos.position + offset, Time.deltaTime * followSpeed);
    }
}
