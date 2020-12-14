using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomPhysics
{
    public class NetMovement : PhysicsObject
    {
        private CannonControls cannonControls = CannonControls.instance;

        private void Awake()
        {
            Position = transform.position;
            Velocity = cannonControls.CannonDirection * cannonControls.cannonStrength;
            Debug.Log("Position: " + Position + ", Velocity = " + Velocity);
        }

        private void FixedUpdate()
        {
            if (Position.y < -100)
            {
                Destroy(this.gameObject);
            }
            else
            {
                Position = CustomPhysics.GetEulerPosition(Position, Velocity);
                Velocity = CustomPhysics.GetEulerVelocity(Velocity);

                transform.position = Position;
            }

        }
    }
}
