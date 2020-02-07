using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed;
    public GameObject camera;
    public float rotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //bool rightInput = Input.GetKey(KeyCode.RightArrow);
        //bool leftInput = Input.GetKey(KeyCode.LeftArrow);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            print("Pressed Right");
            rotation -= speed/2;
            //transform.position += Vector3.right * speed * Time.deltaTime;
            rb2d.MoveRotation(rotation);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            print("Pressed Left");
            rotation += speed/2;
            //transform.position += Vector3.left * speed * Time.deltaTime;
            rb2d.MoveRotation(rotation);
        }
        var pos = camera.transform.position;
        pos.x = transform.position.x;
        camera.transform.position = pos;
    }
}
