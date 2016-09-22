using UnityEngine;
using System.Collections;

public class rotationCamera : MonoBehaviour {

    public GameObject target = null;
    public float speedMod = 10.0f;
    
    private Vector3 point;
    private float direction;
    private bool hasDirection = false;
    private bool dragOrigin = false;

    void start()
    {
        point = target.transform.position;//get target's coords
        transform.LookAt(point);//makes the camera look to it
    }

    
    void Update()
    {
        if (dragOrigin) {
            
            hasDirection = false;

            if (Input.GetAxis("Mouse X") > 0) {
                direction = Time.deltaTime;
                hasDirection = true;
            }

            if (Input.GetAxis("Mouse X") < 0) {
                direction = -Time.deltaTime;
                hasDirection = true;
            }
        }

        if (!Input.GetMouseButton(1)) return;

        if (hasDirection) {
            target.transform.RotateAround(point, new Vector3(0.0f, 1.0f, 0.0f), 20 * direction * speedMod);
        }
    }

    void OnGUI()
    {
        if (Input.GetMouseButtonDown(1))
        {
            dragOrigin = true;
        }

        if (Input.GetMouseButtonUp(1))
        {
            dragOrigin = false;
        }
    }
}
