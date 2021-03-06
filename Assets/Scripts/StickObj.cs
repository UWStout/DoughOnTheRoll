﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickObj : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D c)
    {
        // Code for player to stick to objects around the map.
        if (c.gameObject.CompareTag("PickUp"))
        {
            c.transform.parent = gameObject.transform;
            var joint = gameObject.AddComponent<FixedJoint2D>();
            joint.connectedBody = c.gameObject.GetComponent<Rigidbody2D>();
        }
        if (c.gameObject.CompareTag("Cabinet"))
        {
            c.transform.parent = gameObject.transform;
            var joint = gameObject.AddComponent<FixedJoint2D>();
            joint.connectedBody = c.gameObject.GetComponent<Rigidbody2D>();
        }
    }
}
