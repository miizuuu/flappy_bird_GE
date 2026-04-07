using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float spawnRate = 4f;
    
    [SerializeField] private Vector2 minMaxHeight;
    
    private void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    IEnumerator SpawnPipe()
    { 
        Instantiate(pipePrefab, new Vector3(1, Random.Range(minMaxHeight.x, minMaxHeight.y), 0), Quaternion.identity);
        yield return new WaitForSeconds(spawnRate);
        
        if(spawnRate >= 1.5f)
            spawnRate -= 0.1f;
        
        StartCoroutine(SpawnPipe());
    }
}
