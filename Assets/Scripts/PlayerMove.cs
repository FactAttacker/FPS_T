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
        // ĳ��
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        // ������� �Է� ������ �̵��� �ϰ� �ʹ�.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        dir.Normalize();
        dir = transform.TransformDirection(dir);
        
        // �÷��̾ �̵��Ϸ��� �������� ȸ���Ѵ�.
        //transform.rotation = Quaternion.LookRotation(dir);

        // ĳ���� ��Ʈ�ѷ��� �ٴڿ� ������� �߷� ���ӵ��� 0���� �ʱ�ȭ�Ѵ�.
        //if(cc.collisionFlags == CollisionFlags.Below)
        if (cc.isGrounded)
        {
            yVelocity = 0;
            jumpCount = 2;
        }

        // "Jump" Ű��  ������ �������� ������ �ϰ� �ʹ�.
        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            yVelocity = jumpPower;
            jumpCount--;
        }

        // �߷� ���ӵ��� �����ϰ� �ʹ�.
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        cc.Move(dir * moveSpeed * Time.deltaTime);
        //cc.SimpleMove(dir * moveSpeed);

       
    }

}
