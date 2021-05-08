using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    public float movementFactor;
    public Vector3 movementVector;
    public float timePeriod = 3f;
    Vector3 startingPos;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float cycle = Time.time/timePeriod;
        float rawSinWave = Mathf.Sin(cycle + Mathf.PI);
        movementFactor = (rawSinWave+1) /2f;
        transform.position = startingPos + movementVector*movementFactor;
    }
}
