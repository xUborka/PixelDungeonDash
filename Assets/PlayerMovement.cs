using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float RunSpeed = 1f;
    [SerializeField] private float jump_force = 10f;

    [Header("Components")]
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = new Vector2(RunSpeed, _rigidbody.velocity.y);
        _animator.SetFloat("Speed", _rigidbody.velocity.x);
        if (Input.GetButtonDown("Jump"))
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, 0.0f);
            _rigidbody.velocity += Vector2.up * jump_force;
        }
    }

    void FixedUpdate()
    {

    }
}
