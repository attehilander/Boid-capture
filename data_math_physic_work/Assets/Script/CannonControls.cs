using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonControls : MonoBehaviour
{
    public static CannonControls instance;

    private Ray ray;

    public Vector2 CannonDirection { get => cannonDirection; set => cannonDirection = value; }
    private Vector2 cannonDirection;

    public float cannonStrength = 0.0f;
    public GameObject netPrefab = null;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        CannonDirection = (ray.origin - this.gameObject.transform.position).normalized;

        if (Input.GetMouseButtonDown(0))
        {
            FireCannon();
        }
    }

    private void FireCannon()
    {
        Instantiate(netPrefab, this.gameObject.transform);
    }
}
