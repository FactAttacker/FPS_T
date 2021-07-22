using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraType2 : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float followSpeed = 3;
    public float forwardDisatance = 3;

    void Start()
    {
        
    }

    void Update()
    {
        // offset 값을 플레이어의 상대 좌표로 계산한다.
        Vector3 localPos = player.transform.TransformDirection(offset);

        transform.position = Vector3.Lerp(transform.position, player.position + localPos, Time.deltaTime * followSpeed);

        // 플레이어로부터 일정 거리만큼 앞쪽을 바라보도록 회전시킨다.
        //Vector3 dir = (player.position + player.forward * forwardDisatance - transform.position).normalized;
        //transform.forward = dir;
    }
}
