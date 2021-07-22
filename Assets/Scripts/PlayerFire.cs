using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // ���콺 �� Ŭ���� �ϸ� FirePosition ��ġ�κ��� ī�޶� �ٶ󺸰� �ִ� �������� ����ź�� �����ϰ� �߻��Ѵ�.
    public GameObject bombPrefab;
    public Transform firePos;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            // �ѱ��� ����ź ������Ʈ�� �����Ѵ�.
            GameObject bomb = Instantiate(bombPrefab, firePos.position, Quaternion.identity);

            // ����ź ������Ʈ�� BombAction ��ũ��Ʈ�� �����´�.
            BombAction ba = bomb.GetComponent<BombAction>();
            //Rigidbody rb = bomb.GetComponent<Rigidbody>();

            // ����ź �߻� �Լ��� �����Ѵ�.
            Vector3 direction = Camera.main.transform.forward + Camera.main.transform.up;
            direction.Normalize();

            ba.CastBomb(direction, 20);
            //rb.AddForce(direction * 12, ForceMode.VelocityChange);
            //rb.AddTorque(direction * 12, ForceMode.VelocityChange);
        }
    }
}
