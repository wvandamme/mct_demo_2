using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollider : MonoBehaviour
{

    public Canvas canvas;

    private void OnEnable()
    {
        canvas.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (canvas.isActiveAndEnabled)
        {
            canvas.gameObject.transform.rotation = Quaternion.LookRotation(canvas.worldCamera.transform.forward);
        }
    }

    private void OnTriggerEnter(Collider collider_)
    {
        if (collider_.gameObject.tag == "MainCamera")
        {
            canvas.gameObject.SetActive(true);
            canvas.worldCamera = collider_.GetComponent<Camera>();
            
        }
    }

    private void OnTriggerExit(Collider collider_)
    {
        if (collider_.gameObject.tag == "MainCamera")
        {
            canvas.gameObject.SetActive(false);
        }
    }

}
