using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rotationSpeed;

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.time, Space.World);
    }
}
