using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

    public GameObject target = null;
    public GameObject cameraMain = null;
    public float scale = 3.5f; 

    private Vector3 positionOffSet = Vector3.zero;  // The position the camera is moving towards.

    private void LateUpdate() {

        if (target != null) {

            float positionX = target.transform.position.x - positionOffSet.x;
            float positionY = target.transform.position.y - positionOffSet.y;
            float positionZ = target.transform.position.z - positionOffSet.z;
            
            transform.position = new Vector3(positionX, positionY, positionZ);
            transform.localScale = new Vector3(0, 0, scale);
        }
    }
    
}
