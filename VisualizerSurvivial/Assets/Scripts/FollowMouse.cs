using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Camera cam = Camera.main;
        Vector3 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = cam.transform.position.z + cam.nearClipPlane;

        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;
        Vector3 size = this.GetComponent<Renderer>().bounds.size;

        mousePosition.x = Mathf.Min((width-size.x)/2, Mathf.Max((-width+size.x)/2, mousePosition.x));
        mousePosition.y = Mathf.Min((height-size.y)/2, Mathf.Max((-height+size.y)/2, mousePosition.y));
        transform.position = mousePosition;
    }

}
