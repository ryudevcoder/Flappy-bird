using System;
using Unity.Android.Types;
using Unity.Mathematics;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float jumpForce = 3;
    [SerializeField] private float rotationSpeed = 10;
    [SerializeField] private GameObject GameOver;
    private bool isGameOver = false;
    private Rigidbody2D rigidbody;


    private void Start()
    {
        GameOver.SetActive(false);
    }

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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) 
        {
            Time.timeScale = 0f;
            GameOver.SetActive(true);
            isGameOver = true;
        }
    }
}
