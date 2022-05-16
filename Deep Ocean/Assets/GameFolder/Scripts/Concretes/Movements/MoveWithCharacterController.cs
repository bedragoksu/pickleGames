using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DeepOcean.Abstracts.Controllers;
using DeepOcean.Abstracts.Movements;

namespace DeepOcean.Movements
{
    public class MoveWithCharacterController : IMover
    {
        CharacterController _characterController;
        float _moveSpeed;

        public MoveWithCharacterController(IEntityController entityController)
        {
            _characterController = entityController.transform.GetComponent<CharacterController>();
        }

        public void MoveAction(float direction, float _moveSpeed)
        {
            Vector2 worldPosition = _characterController.transform.TransformDirection(direction, 0f, 0f);
            Vector2 movement = worldPosition * Time.deltaTime * _moveSpeed;

            _characterController.Move(movement);
        }

    }
}

