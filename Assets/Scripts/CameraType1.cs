using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraType1 : MonoBehaviour
{
    // �÷��̾�κ��� ������ ��ġ�� �����Ѵ�.
    // �÷��̾��� ȸ�����κ��� ������ ���� �ʴ´�.

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
