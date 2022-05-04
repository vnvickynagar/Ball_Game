using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Move : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public FixedJoystick variableJoystick;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
           // rb.velocity = new Vector3(-3,0,0);
            rb.AddForce(-speed*Time.deltaTime,0,0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //rb.velocity = new Vector3(3, 0, 0);
            rb.AddForce(speed * Time.deltaTime,0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //rb.velocity = new Vector3(0, 0, -3);
            rb.AddForce( 0, 0, - speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //rb.velocity = new Vector3(0, 0, 3);
            rb.AddForce(0, 0, speed * Time.deltaTime);
        }
        if (rb.position.y < -21f)
        {
            
            FindObjectOfType<GameManager>().reStart();
        }
    }

}
