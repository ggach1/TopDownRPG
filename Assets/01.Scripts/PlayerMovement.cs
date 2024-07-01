using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private Rigidbody2D _rigid;

    private PlayerInput _playerInput;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();

        _playerInput = GetComponent<PlayerInput>();
    }

    private void FixedUpdate()
    {
        _rigid.velocity = _playerInput._moveDir * _speed;
    }
}
