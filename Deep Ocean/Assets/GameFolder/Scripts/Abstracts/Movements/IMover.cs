using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeepOcean.Abstracts.Movements
{
    public interface IMover
    {
        void MoveAction(float direction, float moveSpeed);
    }
}
