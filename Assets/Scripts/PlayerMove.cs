using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 6;
    public float gravity = -10;
    public float jumpPower = 10;
    public int jumpCount = 2;

    CharacterController cc;
    float yVelocity = 0;


    void Start()
    {
        // 캐싱
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        // 사용자의 입력 방향대로 이동을 하고 싶다.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        dir.Normalize();
        dir = transform.TransformDirection(dir);
        
        // 플레이어가 이동하려는 방향으로 회전한다.
        //transform.rotation = Quaternion.LookRotation(dir);

        // 캐릭터 콘트롤러가 바닥에 닿았으면 중력 가속도를 0으로 초기화한다.
        //if(cc.collisionFlags == CollisionFlags.Below)
        if (cc.isGrounded)
        {
            yVelocity = 0;
            jumpCount = 2;
        }

        // "Jump" 키를  누르면 위쪽으로 점프를 하고 싶다.
        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            yVelocity = jumpPower;
            jumpCount--;
        }

        // 중력 가속도를 적용하고 싶다.
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        cc.Move(dir * moveSpeed * Time.deltaTime);
        //cc.SimpleMove(dir * moveSpeed);

       
    }

}
