using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DeepOcean.Abstracts.Movements;
using DeepOcean.Abstracts.Inputs;
using DeepOcean.Abstracts.Controllers;
using DeepOcean.Movements;

namespace DeepOcean.Controllers
{
    public class PlayerController : MonoBehaviour, IEntityController
    {
        private float _moveSpeed = 5f;
        private SpriteRenderer _spriteRenderer;

        IMover _mover;
        IInputReader _input;

        float _direction;

        void Awake()
        {
            _input = GetComponent<IInputReader>();
            _mover = new MoveWithCharacterController(this);


        }

        void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }


        void Update()
        {
            _direction = _input.Direction;
        }

        void FixedUpdate()
        {
            _mover.MoveAction(_direction, _moveSpeed);

            if (_direction == -1)
            {
                _spriteRenderer.flipX = false;
            }
            else if (_direction == 1)
            {
                _spriteRenderer.flipX = true;
            }
        }
    }
}

