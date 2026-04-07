using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlappyController : MonoBehaviour
{
    [SerializeField] private float jumpForce, rotationSpeed;
    private Rigidbody2D _rb;
    [SerializeField] TextMeshProUGUI scoreText;

    public int score;
    
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") || (Input.GetKeyDown(KeyCode.Space)))
        {
            _rb.linearVelocity = Vector2.up * jumpForce;
            AudioManager.Instance.PlayFlyingSound();
        }
        
        transform.rotation = Quaternion.Euler(0f, 0f, _rb.linearVelocity.y * rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioManager.Instance.PlayHitSound();
        GameManager.Instance.GameOver(); 
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        score++;
        scoreText.text = score.ToString();
        AudioManager.Instance.PlayScore();
    }
}