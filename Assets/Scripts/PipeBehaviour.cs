using UnityEngine;

public class PipeBehaviour : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    
    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < -1)
        {
            transform.position = new Vector2(1, Random.Range(-0.5f, 0.5f));
            moveSpeed += 0.05f;
        }
    }
}
