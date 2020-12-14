using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomPhysics
{
    public class CustomPhysics
    {
        public static float timestep = Time.fixedDeltaTime * 5;
        public static Vector2 gravity = new Vector2(0f, -9.81f);

        public static Vector2 GetEulerPosition(Vector3 position, Vector2 velocity)
        {
            Vector3 newPosition = new Vector3();

            newPosition.x = position.x + velocity.x * timestep;
            newPosition.y = position.y + velocity.y * timestep;
            newPosition.z = position.z;

            return newPosition;
        }

        public static Vector2 GetEulerVelocity(Vector2 velocity)
        {
            Vector2 newVelocity = new Vector2();

            newVelocity.x = velocity.x + gravity.x * timestep;
            newVelocity.y = velocity.y + gravity.y * timestep;

            return newVelocity;
        }
    }
}

