using System;
using UnityEngine;

public class pipeBehaviour : MonoBehaviour
{
    [SerializeField] private float MoveSpeed=2f;

    private void Update()
    {
        transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);
        if (transform.position.x <= -1.28f)
        {
                
        }
    }
}
