using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //print("안녕! 나는 콜라이더라고 해");
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //print("안녕! 나는 캐릭터 콘트롤러라고 해");
    }
}
