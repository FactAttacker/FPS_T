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
        // offset ���� �÷��̾��� ��� ��ǥ�� ����Ѵ�.
        Vector3 localPos = player.transform.TransformDirection(offset);

        transform.position = Vector3.Lerp(transform.position, player.position + localPos, Time.deltaTime * followSpeed);

        // �÷��̾�κ��� ���� �Ÿ���ŭ ������ �ٶ󺸵��� ȸ����Ų��.
        //Vector3 dir = (player.position + player.forward * forwardDisatance - transform.position).normalized;
        //transform.forward = dir;
    }
}
