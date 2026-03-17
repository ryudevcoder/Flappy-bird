using System;
using System.Collections;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class Pipegenerator : MonoBehaviour
{
    [SerializeField]private GameObject pipePrefab;
    
    [SerializeField] public float spawnRate;


    private void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    private IEnumerator SpawnPipe()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            GameObject SpawnedPipe=Instantiate(pipePrefab,transform.position,quaternion.identity);
            Destroy(SpawnedPipe,5f);
        }
    }
}
