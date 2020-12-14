using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomPhysics
{
    public class PhysicsObject : MonoBehaviour
    {
        public Vector2 Velocity { get => velocity; set => velocity = value; }
        public Vector3 Position { get => position; set => position = value; }

        private Vector2 velocity;
        private Vector3 position;

    }
}
