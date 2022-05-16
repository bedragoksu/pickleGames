using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DeepOcean.Abstracts.Inputs;

namespace DeepOcean.Inputs
{
    public class InputReader : MonoBehaviour, IInputReader
    {
        public float Direction { get; private set; }

        public void Right()
        {
            Direction = 1;
        }

        public void Left()
        {
            Direction = -1;
        }

        public void Stop()
        {
            Direction = 0;
        }
    }

}
