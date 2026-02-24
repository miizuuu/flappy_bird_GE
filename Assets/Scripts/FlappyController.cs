using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlappyController : MonoBehaviour
{
    [SerializeField] private float jumpForce = 1;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _rb.linearVelocity = Vector2.up * jumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            //codigo insano de morte
        }
    }
}