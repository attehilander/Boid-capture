using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAtCursor : MonoBehaviour
{
    private GameObject cannon;

    private void Awake()
    {
        cannon = this.gameObject;
    }

    private void Update()
    {
        cannon.transform.right = new Vector3(CannonControls.instance.CannonDirection.x, CannonControls.instance.CannonDirection.y, 0);
    }
}
