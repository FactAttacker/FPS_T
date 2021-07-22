using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    //public Transform targetPos;

    //GameObject obj;
    //float currentTime = 0;

    //void Start()
    //{

    //}

    //void Update()
    //{
    //    if (obj != null)
    //    {
    //        Elevate(obj);
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name.Contains("Player"))
    //    {
    //        obj = other.gameObject;
    //    }
    //}

    //void Elevate(GameObject player)
    //{
    //    if (currentTime <= 1.1f)
    //    {
    //        player.GetComponent<PlayerMove>().ChangeInputState(false);

    //        currentTime += Time.deltaTime;
    //        player.transform.position = Vector3.Lerp(transform.position, targetPos.position, currentTime);
    //    }
    //    else
    //    {
    //        player.GetComponent<PlayerMove>().ChangeInputState(true);
    //        obj = null;
    //        targetPos.GetComponent<BoxCollider>().enabled = true;
    //        GetComponent<BoxCollider>().enabled = false;
    //    }
    //}
}
