using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 0f;
    private float time = 0f;
    void Update()
    {
        time += Time.deltaTime;

        if (time > 3f){
            time = 0f;
            rotationSpeed += 30f;
        }
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
