using UnityEngine;
using System.Collections;

public class scrollCamera : MonoBehaviour
{
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (GetComponent<Camera>().fieldOfView > 10)
            GetComponent<Camera>().fieldOfView = GetComponent<Camera>().fieldOfView - 1;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (GetComponent<Camera>().fieldOfView < 70)
            GetComponent<Camera>().fieldOfView = GetComponent<Camera>().fieldOfView + 1;
        }
    }
}
