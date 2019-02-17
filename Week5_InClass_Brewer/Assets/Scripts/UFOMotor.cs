using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOMotor : MonoBehaviour
{

    Vector3 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // creates a ray from camera point to terrain/game object
        if (Input.GetMouseButton(0))
        {
            Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            // defining the raycast
            RaycastHit hit;
            // if the ray cast hits something
            if (Physics.Raycast(cameraRay, out hit))
            {
                //gives the point at which the ray hits
                //Debug.Log(hit.point);
                //target position of a new vector3 at the hit point x, y + 5 units, z
                targetPosition = new Vector3(hit.point.x, hit.point.y + 30, hit.point.z);
                //transform.position = targetPosition; - makes it warp, we want it to move every frame

            }
        }
        //takes the original position and target position and interpolates between them
        transform.position = Vector3.Lerp(transform.position, targetPosition, 0.05f);
    }
}
