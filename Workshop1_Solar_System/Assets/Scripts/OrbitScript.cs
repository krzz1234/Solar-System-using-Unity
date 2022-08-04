using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitScript : MonoBehaviour
{
    public static float Speed = 10.0f;
    public float OrbitalPeriod = 1.0f;
    public float RotationPeriod = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, 360.0f / OrbitalPeriod * Time.deltaTime * Speed, Space.Self);
        Transform child = transform.GetChild(0);
        child.Rotate(Vector3.up, 360.0f / (RotationPeriod / 24.0f) * Time.deltaTime * Speed, Space.Self);

    }
}
