﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float cameraDistance = 10.0f;

    void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height) / cameraDistance);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
