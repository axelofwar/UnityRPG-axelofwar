using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrance : MonoBehaviour
{
    public string transitionName;
    // Start is called before the first frame update
    void Start()
    {
        // if (transitionName == null)
        // {
        //     // transitionName = AreaExit.areaTransitionName;
        //     // transitionName = AreaExit.areaToLoad;
        //     // transitionName = PlayerController.instance.areaTransitionName;
        //     // transitionName = AreaExit.areaTransitionName; // we can call this way because its static and there won't be another
        // }

        if (transitionName == PlayerController.instance.areaTransitionName)
        {
            PlayerController.instance.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
