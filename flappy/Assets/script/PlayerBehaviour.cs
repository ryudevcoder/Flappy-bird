using System;
using Unity.Mathematics;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float jumpForce = 3;
    [SerializeField] private float rotationSpeed = 10;
    private Rigidbody2D rigidbody;
    
    
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            rigidbody.linearVelocity = Vector2.up * jumpForce;
            
            
        }
        
        transform.rotation=Quaternion.Euler(0f,0f,rigidbody.linearVelocity.y*rotationSpeed);
    }
}
