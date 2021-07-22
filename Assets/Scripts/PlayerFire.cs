using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // 마우스 우 클릭을 하면 FirePosition 위치로부터 카메라가 바라보고 있는 방향으로 수류탄을 생성하고 발사한다.
    public GameObject bombPrefab;
    public Transform firePos;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            // 총구에 수류탄 오브젝트를 생성한다.
            GameObject bomb = Instantiate(bombPrefab, firePos.position, Quaternion.identity);

            // 수류탄 오브젝트의 BombAction 스크립트를 가져온다.
            BombAction ba = bomb.GetComponent<BombAction>();
            //Rigidbody rb = bomb.GetComponent<Rigidbody>();

            // 수류탄 발사 함수를 실행한다.
            Vector3 direction = Camera.main.transform.forward + Camera.main.transform.up;
            direction.Normalize();

            ba.CastBomb(direction, 20);
            //rb.AddForce(direction * 12, ForceMode.VelocityChange);
            //rb.AddTorque(direction * 12, ForceMode.VelocityChange);
        }
    }
}
