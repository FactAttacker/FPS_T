using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public float rotSpeed = 200;
    float mx = 0;


    void Start()
    {
        
    }

    void Update()
    {
        mx += Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime;

        transform.rotation = Quaternion.Euler(new Vector3(0, mx, 0));
    }
}
