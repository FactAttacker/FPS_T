using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public Transform player;

    // 마우스 드래그 방향에 따라서 카메라가 회전되게 하고 싶다.
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

        // 유니티 에디터에서 Rotation 값을 0 ~ 360도로 환산하고 있기 때문에 아래 방식으로는 제한이 불가하다.
        //Vector3 cameraRot = transform.eulerAngles;
        //cameraRot.x = Mathf.Clamp(cameraRot.x, -60.0f, 60.0f);
        //transform.eulerAngles = cameraRot;
    }
}
