using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour
{
    private float speed = 100f;

    private void Update()
    {
        transform.Rotate(new Vector3(0, speed, 0) * Time.deltaTime);
    }
}
