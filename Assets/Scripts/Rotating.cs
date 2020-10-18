using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour
{

    public float speed = 30.0f;

    bool rotate = false;


    public void OnToggle()
    {
        rotate = !rotate;
    }

    void Update()
    {
        if (rotate)
        {
            transform.Rotate(Vector3.one * speed * Time.deltaTime);
        }   
    }
}
