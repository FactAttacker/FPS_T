using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public Transform target;
    public float followSpeed = 2.0f;

    //public Transform[] players = new Transform[2];
    public Transform[] camPos = new Transform[2];

    // ī�޶� ���� ���� ���
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
        // ���콺 ���� �̵� ���� ������Ų��.
        wheelDistance += Input.GetAxis("Mouse ScrollWheel");
        wheelDistance = Mathf.Clamp01(wheelDistance);

        // 3��Ī ��ġ���� 1��Ī ��ġ���� ���콺 �� ���� ���� ���� ��ġ�� ��ȭ��Ų��.
        Vector3 middlePos = Vector3.Lerp(camPos[0].position, camPos[1].position, wheelDistance);

        // 3��Ī ��ġ���� 1��Ī ��ġ���� ���콺 �� ���� ���� ���� ȸ�� ���� ��ȭ��Ų��.
        //transform.rotation = Quaternion.Lerp(camPos[0].rotation, camPos[1].rotation, wheelDistance);

        #region
        //if(Input.GetButtonDown("Jump"))
        //{
        //    // 0�� 1�� ��ȣ�� ����ؼ� �ٲ۴�.
        //    selectedPlayer++;
        //    selectedPlayer %= 2;

        //    target = players[selectedPlayer];
        //}
        #endregion

        // �Ÿ��� ���� ī�޶� ���� ���¸� �����Ѵ�.
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
            // Ÿ���� �Ѿư���.
            Vector3 camPos = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * followSpeed);
            transform.position = camPos;
        }
        else
        {
            transform.position = targetPos;
        }
    }
}
