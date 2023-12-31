using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float rotationSpeed;

    private Vector2 movementValue;
    private float lookValue;

    private Rigidbody rigidbody;


    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rigidbody = GetComponent<Rigidbody>();
    }


    public void OnMove(InputValue value)
    {
        movementValue = value.Get<Vector2>() * speed;
    }


    public void OnLook(InputValue value)
    {
        lookValue = value.Get<Vector2>().x * rotationSpeed;
    }


    void Update()
    {
        rigidbody.AddRelativeForce(
            movementValue.x * Time.deltaTime,
            0,
            movementValue.y * Time.deltaTime);

        rigidbody.AddRelativeTorque(0, lookValue * Time.deltaTime, 0);
    }
}
