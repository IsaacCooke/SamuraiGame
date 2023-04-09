using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PlayerController : MonoBehaviour
{
    public float speed;
    
    private CharacterController controller;
    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>().normalized;
        float targetAngle = Mathf.Atan2(movementVector.x, movementVector.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, targetAngle, 0);
        controller.Move(movementVector * speed * Time.deltaTime);
        Debug.Log("Moved with vector: " + movementVector + " and speed: " + speed);
    }

    void OnJump()
    {

    }

    void OnLook(InputValue rotationValue)
    {
        Vector2 rotationVector = rotationValue.Get<Vector2>().normalized;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
