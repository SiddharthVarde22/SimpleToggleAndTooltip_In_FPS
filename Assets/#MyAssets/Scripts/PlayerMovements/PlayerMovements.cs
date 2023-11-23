using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField]
    float movementSpeed = 10, rotationSpeed = 5;

    float horizontalInput, verticalInput, mouseXInput;

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        mouseXInput = Input.GetAxis("Mouse X");

        MovePlayer();
        RotatePlayer();
    }

    private void MovePlayer()
    {
        transform.position += movementSpeed * Time.deltaTime * ((transform.right * horizontalInput) + (transform.forward * verticalInput));
    }

    private void RotatePlayer()
    {
        transform.rotation *= Quaternion.Euler(0, mouseXInput * rotationSpeed, 0);
    }
}
