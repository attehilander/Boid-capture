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
            //Debug.Log("Velocity = " + Velocity);
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

        private void OnCollisionEnter(Collision collision)
        {
            Velocity = CustomPhysics.GetReflection(Velocity, collision.GetContact(0).normal);
            Debug.Log(Velocity);

            Vector3 Velocity3 = new Vector3(Velocity.x, Velocity.y, 0);
            Debug.DrawLine(collision.GetContact(0).point, collision.GetContact(0).point + Velocity3, Color.green, 1f);
        }
    }
}
