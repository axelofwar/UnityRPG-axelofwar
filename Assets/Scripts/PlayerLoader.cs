using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    public static GameObject player; //GameObject not player controller because we want to load the whole prefab if not present
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerController.instance == null)
        {
            GameObject playerPrefab = Resources.Load("player") as GameObject;
            PlayerLoader.player = Instantiate(playerPrefab, transform.position, transform.rotation);
            // AreaExit.areaTransitionName = PlayerController.instance.areaTransitionName;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
