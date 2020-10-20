
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;

public class TouchContoller : MonoBehaviour
{

    public ARRaycastManager raycast_manager;
    public Camera camera;
    public GameObject world;

    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void FixedUpdate()
    {

        if (Input.touchCount != 1) return;
        
        Touch touch = Input.GetTouch(0);

        if (touch.phase != TouchPhase.Ended) return;

        if (EventSystem.current.IsPointerOverGameObject(touch.fingerId))
        {
            return;
        }

        Ray ray = camera.ScreenPointToRay(touch.position);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("HIT");
        }

        if (raycast_manager.Raycast(touch.position, hits))
        {  
            Instantiate(world, hits[0].pose.position, Quaternion.identity);
        }
          
    }
}
