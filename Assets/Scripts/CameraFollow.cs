using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public Transform target;
    public float followSpeed = 2.0f;

    //public Transform[] players = new Transform[2];
    public Transform[] camPos = new Transform[2];

    // 카메라 시점 상태 상수
    public enum ViewState
    {
        FirstPersonView,
        ThirdPersonView
    }
    public ViewState viewState = ViewState.ThirdPersonView;

    //int selectedPlayer = 0;
    float wheelDistance = 0;

    void Start()
    {
        //target = players[selectedPlayer];
    }

    void Update()
    {
        // 마우스 휠의 이동 값을 누적시킨다.
        wheelDistance += Input.GetAxis("Mouse ScrollWheel");
        wheelDistance = Mathf.Clamp01(wheelDistance);

        // 3인칭 위치에서 1인칭 위치까지 마우스 휠 누적 값에 따라 위치를 변화시킨다.
        Vector3 middlePos = Vector3.Lerp(camPos[0].position, camPos[1].position, wheelDistance);

        // 3인칭 위치에서 1인칭 위치까지 마우스 휠 누적 값에 따라 회전 값을 변화시킨다.
        //transform.rotation = Quaternion.Lerp(camPos[0].rotation, camPos[1].rotation, wheelDistance);

        #region
        //if(Input.GetButtonDown("Jump"))
        //{
        //    // 0과 1의 번호를 계속해서 바꾼다.
        //    selectedPlayer++;
        //    selectedPlayer %= 2;

        //    target = players[selectedPlayer];
        //}
        #endregion

        // 거리에 따라 카메라 추적 상태를 변경한다.
        if(wheelDistance < 1)
        {
            FollowTarget(ViewState.ThirdPersonView, middlePos);
        }
        else
        {
            FollowTarget(ViewState.FirstPersonView, camPos[1].position);
        }
    }

    void FollowTarget(ViewState type, Vector3 targetPos)
    {
        if (type == ViewState.ThirdPersonView)
        {
            // 타겟을 쫓아간다.
            Vector3 camPos = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * followSpeed);
            transform.position = camPos;
        }
        else
        {
            transform.position = targetPos;
        }
    }
}
