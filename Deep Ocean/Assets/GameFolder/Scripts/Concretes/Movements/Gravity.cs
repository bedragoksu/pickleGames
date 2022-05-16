using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeepOcean.Movements
{
    [RequireComponent(typeof(CharacterController))]
    public class Gravity : MonoBehaviour
    {
        float _gravity = -9.81f;
        CharacterController _characterController;
        Vector2 _velocity;

        void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }

        void Update()
        {
            if (_characterController.isGrounded) _velocity.y = 0f;

            _velocity.y += _gravity * Time.deltaTime;

            _characterController.Move(_velocity * Time.deltaTime);
        }
    }
}

