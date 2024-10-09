using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotsped1 = 0.0f;
    public float rotsped2 = 0.0f;
    public float rotsped3 = 0.0f;
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(new Vector3(rotsped1, rotsped2, rotsped3) * Time.deltaTime);

    }
}