using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeepOcean.Movements
{
    [RequireComponent(typeof(CharacterController))]
    public class Gravity : MonoBehaviour
    {
        private float _gravity = -9.81f;
        private float _jumpSpeed = 5f;
        
        Vector2 _velocity;
        Animator _anim;

        CharacterController _characterController;

        void Awake()
        {
            _characterController = GetComponent<CharacterController>();
            _anim = GetComponent<Animator>();

        }

        void Update()
        {
            if (_characterController.isGrounded) _velocity.y = 0f;

            _velocity.y += _gravity * Time.deltaTime;

            _characterController.Move(_velocity * Time.deltaTime);
        }

        public void Jump()
        {
            
            for (int i = 0; i < 20; i++) { 
            if (_characterController.isGrounded) _velocity.y = _jumpSpeed;

            _velocity.y += _gravity * Time.deltaTime;

            _characterController.Move(_velocity * Time.deltaTime);
            }
            _anim.SetTrigger("isJump");
        }

    }
}

