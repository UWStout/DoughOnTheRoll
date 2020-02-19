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
    public GameObject glow;
    public GameObject lego;

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
            speed.y = speed.y / 5 + jumpForce;
            rb2d.velocity = speed;
            canJump = false;
            glow.SetActive(false);
        }
        var pos = camera.transform.position;
        if (transform.position.x > (-100) /*&& transform.position.x < 266*/)
        {
            pos.x = transform.position.x;
        }
        if (transform.position.y > (-4) && transform.position.y < 25)
        {
            pos.y = transform.position.y;
        }

        camera.transform.position = pos;
    }

    void OnCollisionEnter2D(Collision2D collided)
    {
        if (collided.gameObject.CompareTag("ground"))
        {
            canJump = true;
            glow.SetActive(true);
        }
        if (collided.gameObject.CompareTag("Lego Piece")){
            lego.SetActive(true);
            Destroy(collided.gameObject);
        }
    }
}
