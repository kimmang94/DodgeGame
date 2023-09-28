using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Rotaor : MonoBehaviour
{
    public float rotationSpeed = 60f;
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,  rotationSpeed* Time.deltaTime, 0f);
        transform.Rotate(Input.gyro.rotationRateUnbiased.x, Input.gyro.rotationRateUnbiased.y,Input.gyro.rotationRateUnbiased.z);
    }
}
