using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; //in this case it's player - but we can change this to other targets
    // Start is called before the first frame update
    void Start()
    {
        target = PlayerController.instance.transform; // set the target to the position of the player in this instance
    }

    // LateUpdate is called once per frame after Update
    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        // update the transform of the attached object - aka the camera - to the pose of the taget and keep initial height of cam
    }
}
