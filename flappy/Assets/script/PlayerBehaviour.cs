using System;
using System.Collections;
using TMPro;
using Unity.Android.Types;
using Unity.Mathematics;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float jumpForce = 3;
    [SerializeField] private float rotationSpeed = 10;
    private Rigidbody2D rigidbody;
    private int pontos;
    [SerializeField] TextMeshProUGUI legal;



    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            rigidbody.linearVelocity = Vector2.up * jumpForce;
            AudioManager.instance.PlayFlyingSound();
        }
        
        transform.rotation=Quaternion.Euler(0f,0f,rigidbody.linearVelocity.y*rotationSpeed);
        
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        AudioManager.instance.PlayHitSound();
        print("Collided with" + collision.gameObject.name);
        jumpForce = 0;
        GameManager.Instance.GameOver();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioManager.instance.PlayScore();
        pontos++;
        legal.text=pontos.ToString();
    }
}
