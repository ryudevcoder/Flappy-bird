using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class Pipegenerator : MonoBehaviour
{
    private float SpawnRate;
    private float ElapsedTime;
    
    
    void update()
    {
        ElapsedTime += Time.deltaTime;
        if (ElapsedTime >= SpawnRate)
        {
            SpawnRate = Random.Range(0.8f, 1.2f);
            ElapsedTime = 0;
        }
    }
    
    
    
}
