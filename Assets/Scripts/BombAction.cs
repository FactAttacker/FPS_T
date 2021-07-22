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

    // ����ź ��ô�Լ�
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
        // ���� ��ġ�κ��� �ݰ� 4.5���� �̳��� �ִ� �ڽ� ������Ʈ���� �˻��Ѵ�.
        Collider[] cols = Physics.OverlapSphere(transform.position, explosionRadius, 1<<8);

        // ���� ���縦 ���ؼ� �� ������Ʈ�� ExplosionBox ��ũ��Ʈ�� �ִ� ExplosionSimulate() �Լ��� �����Ѵ�.
        for(int i = 0; i < cols.Length; i++)
        {
            ExplosionBox eb = cols[i].gameObject.GetComponent<ExplosionBox>();
            eb.ExplosionSimulate(transform.position, explosionRadius);
        }

        Destroy(gameObject);
    }

}
