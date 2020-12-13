using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatAndRotate : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 50;
    [SerializeField] private float floatAmplitude = 2.0f;
    [SerializeField] private float floatFrequency = 0.5f;

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
        startPos.y += 5; 
    }


    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        Vector3 tempPos = startPos;

        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * floatFrequency) * floatAmplitude;

        transform.position = tempPos;
    }
}
