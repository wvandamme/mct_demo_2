using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchContoller : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Debug.Log("TOUCH");
        }
    }
}
