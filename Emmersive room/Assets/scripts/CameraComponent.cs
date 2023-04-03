using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraComponent : MonoBehaviour
{
    private Transform tf;
    public GameObject player;

    private void Start()
    {
        tf = GetComponent<Transform>();
    }
    private void FixedUpdate()
    {
        tf.position = player.transform.position;
    }
}
