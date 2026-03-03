using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlappyController : MonoBehaviour
{
    [SerializeField] private float jumpForce, rotationSpeed;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") || (Input.GetKeyDown(KeyCode.Space)))
        {
            _rb.linearVelocity = Vector2.up * jumpForce;
        }
        
        transform.rotation = Quaternion.Euler(0f, 0f, _rb.linearVelocity.y * rotationSpeed);
    }
}