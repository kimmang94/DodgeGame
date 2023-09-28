using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidBody;
    public float speed = 10f;

    private void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        #region AddForce 의경우 가속이 붙는다
        // if (Input.GetKey(KeyCode.UpArrow) == true)
        // {
        //     playerRigidBody.AddForce(0f, 0f, speed);
        // }
        // if (Input.GetKey(KeyCode.DownArrow) == true)
        // {
        //     playerRigidBody.AddForce(0f, 0f, -speed);
        // }
        // if (Input.GetKey(KeyCode.RightArrow) == true)
        // {
        //     playerRigidBody.AddForce(speed, 0f, 0f,);
        // }
        // if (Input.GetKey(KeyCode.LeftArrow) == true)
        // {
        //     playerRigidBody.AddForce(-speed, 0f, 0f);
        // }
        

        #endregion

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        playerRigidBody.velocity = newVelocity;

    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
