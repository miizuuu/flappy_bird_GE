using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeBehaviour : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float initialPos = 1f;
    [SerializeField] private float endPos = -1f;

    public int score;

    private void Start()
    {
        score = 0;
    }

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < endPos)
        {
            transform.position = new Vector2(initialPos, Random.Range(-0.5f, 0.5f));
            if(moveSpeed < 7f) 
                moveSpeed += 0.01f;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            score++;
            print(score);
        }
    }
}
