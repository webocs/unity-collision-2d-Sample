using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody2D _rigidbody;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.velocity = Vector2.up * moveSpeed;
        } else if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.velocity = Vector2.down * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.velocity = Vector2.left * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.velocity = Vector2.right * moveSpeed;
        }
        else
        {
            _rigidbody.velocity = Vector2.zero;
        }
    }

}
