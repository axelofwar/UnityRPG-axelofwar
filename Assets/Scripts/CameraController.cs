using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; //in this case it's player - but we can change this to other targets
    // Start is called before the first frame update
    public static Camera cam;
    private float targetZoom;
    private float zoomFactor = 3f;
    private float zoomLerpSpeed = 10f;
    
    void Start()
    {
        cam = Camera.main;
        cam.orthographicSize = PlayerPrefs.GetFloat("orthographicSize", cam.orthographicSize);
        targetZoom = cam.orthographicSize;
        
        if(PlayerController.instance == null)
        {
            target = PlayerLoader.player.transform;
        }

        else
        {
            target = PlayerController.instance.transform; // set the target to the position of the player in this instance
        }

    }

    // LateUpdate is called once per frame after Update
    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        // update the transform of the attached object - aka the camera - to the pose of the taget and keep initial height of cam
        
        // if(transform.position == null)
        // {
        //     transform.position = new Vector3(PlayerLoader.player.transform.position.x, PlayerLoader.player.position.y, PlayerLoader.player.position.z);
        // }

        
        // set zoom level based on scroll wheel data
        float scrollData;
        scrollData = Input.GetAxis("Mouse ScrollWheel");
        targetZoom -= scrollData * zoomFactor;
        targetZoom = Mathf.Clamp(targetZoom, 4.5f, 8f);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetZoom, Time.deltaTime * zoomLerpSpeed);
    
        // use PlayerPrefs in order to retain player zoom level
        PlayerPrefs.SetFloat("orthographicSize", cam.orthographicSize);
    }
}
