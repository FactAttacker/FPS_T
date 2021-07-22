using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAction : MonoBehaviour
{
    public float throwPower = 10;
    public float explosionRadius = 4.5f;

    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    // 수류탄 투척함수
    public void CastBomb(Vector3 direction, float throwPower)
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }

        rb.AddForce(direction * throwPower, ForceMode.VelocityChange);
        rb.AddTorque(direction * throwPower, ForceMode.VelocityChange);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 나의 위치로부터 반경 4.5미터 이내에 있는 박스 오브젝트들을 검색한다.
        Collider[] cols = Physics.OverlapSphere(transform.position, explosionRadius, 1<<8);

        // 전수 조사를 통해서 각 오브젝트의 ExplosionBox 스크립트에 있는 ExplosionSimulate() 함수를 실행한다.
        for(int i = 0; i < cols.Length; i++)
        {
            ExplosionBox eb = cols[i].gameObject.GetComponent<ExplosionBox>();
            eb.ExplosionSimulate(transform.position, explosionRadius);
        }

        Destroy(gameObject);
    }

}
