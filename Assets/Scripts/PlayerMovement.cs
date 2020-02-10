using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed;
    public GameObject camera;
    public float jumpForce = 0;
    public bool canJump = false;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //print("Pressed Right");
            //transform.position += Vector3.right * speed * Time.deltaTime;
            rb2d.MoveRotation(transform.rotation.eulerAngles.z - speed / 2);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //print("Pressed Left");
            //transform.position += Vector3.left * speed * Time.deltaTime;
            rb2d.MoveRotation(transform.rotation.eulerAngles.z + speed / 2);
        }
        if (Input.GetKey(KeyCode.UpArrow) && canJump == true)
        {
            Vector2 speed = rb2d.velocity;
            speed.y = speed.y/5 + jumpForce;
            rb2d.velocity = speed;
            canJump = false;
        }
        var pos = camera.transform.position;
        pos.x = transform.position.x;
        pos.y = transform.position.y;
        camera.transform.position = pos;
    }

    void OnCollisionEnter2D(Collision2D collided)
    {
        if (collided.gameObject.CompareTag("ground"))
        {
            canJump = true;
        }
    }
}
