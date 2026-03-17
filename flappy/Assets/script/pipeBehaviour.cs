using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class pipeBehaviour : MonoBehaviour
{
    [SerializeField] private float MoveSpeed=2f;
    [SerializeField] private float alturaMax=0.382f;
    [SerializeField] private float alturaMin=-0.342f;

    private void Awake()
    {
        transform.localPosition=new Vector3(transform.position.x,Random.Range(alturaMax,alturaMin),transform.position.z);
    }
    
    private void Update()
    {
        transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);
    }
    
}
