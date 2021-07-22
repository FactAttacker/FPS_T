using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBox : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //ExplosionSimulate(new Vector3(21, 0.5f, 3), 4.5f);
    }

    void Update()
    {
        
    }

    public void ExplosionSimulate(Vector3 pos, float radius)
    {
        rb.AddExplosionForce(10, pos, radius, 1, ForceMode.Impulse);
    }
}
