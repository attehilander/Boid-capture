using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behavior/Steered Cohesion")]
public class SteeredCohensionBehavior : FilteredFlockBehavior
{

    Vector2 currentVelocity;
    public float agentSmoothTime = 0.5f;
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        //if no neighbors return no adjustment
        if (context.Count == 0)
            return Vector2.zero;

        // add all points together and avarage
        Vector2 cohensionMove = Vector2.zero;
        List<Transform> filteredContext = (filter == null) ? context : filter.Filter(agent, context);
        foreach (Transform item in filteredContext)
        {
            cohensionMove += (Vector2)item.position;
        }
        cohensionMove /= context.Count;

        //create offset from agent position
        cohensionMove -= (Vector2)agent.transform.position;
        cohensionMove = Vector2.SmoothDamp(agent.transform.up, cohensionMove, ref currentVelocity, agentSmoothTime);
        return cohensionMove;
    }


}
