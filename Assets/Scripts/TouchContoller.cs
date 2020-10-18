
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class TouchContoller : MonoBehaviour
{

    public ARRaycastManager raycast_manager;
    public Camera camera;
    public GameObject world;

    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Update()
    {

        if (Input.touchCount != 1) return;
        
        Touch touch = Input.GetTouch(0);

        if (touch.phase != TouchPhase.Ended) return;

        if (raycast_manager.Raycast(touch.position, hits))
        {  
            Instantiate(world, hits[0].pose.position, Quaternion.identity);
        }
          
    }
}
