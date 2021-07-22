using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public Transform player;

    // ���콺 �巡�� ���⿡ ���� ī�޶� ȸ���ǰ� �ϰ� �ʹ�.
    float rotSpeed = 200;

    float mx = 0;
    float my = 0;

    void Start()
    {
        
    }

    void Update()
    {
        //float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        //mx += mouseX * rotSpeed * Time.deltaTime;
        mx = player.eulerAngles.y;
        my += mouseY * rotSpeed * Time.deltaTime;
        my = Mathf.Clamp(my, -60.0f, 60.0f);
        //print(mouseX);

        //Vector3 dir = new Vector3(mouseY * -1.0f, mouseX, 0);
        Vector3 dir = new Vector3(-my, mx, 0);
        //transform.eulerAngles += dir * rotSpeed * Time.deltaTime;
        transform.eulerAngles = dir;

        // ����Ƽ �����Ϳ��� Rotation ���� 0 ~ 360���� ȯ���ϰ� �ֱ� ������ �Ʒ� ������δ� ������ �Ұ��ϴ�.
        //Vector3 cameraRot = transform.eulerAngles;
        //cameraRot.x = Mathf.Clamp(cameraRot.x, -60.0f, 60.0f);
        //transform.eulerAngles = cameraRot;
    }
}
