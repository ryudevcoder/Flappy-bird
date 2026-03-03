using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class pipeBehaviour : MonoBehaviour
{
    [SerializeField] private float MoveSpeed=2f;
    [SerializeField] private float PositionFinal=-1.28f;
    [SerializeField] private float PositionInicial=0.523f;
    [SerializeField] private float AlturaMax=0.382f;
    [SerializeField] private float AlturaMin=-0.342f;
    
    private void Update()
    {
        transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);
        
        if (transform.position.x <= PositionFinal)
        {
            transform.localPosition=new Vector3(PositionInicial,transform.position.y,transform.position.z);
        }
    
    }
    
}
