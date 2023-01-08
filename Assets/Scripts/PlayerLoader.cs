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
            player = Instantiate(playerPrefab, transform.position, transform.rotation);
            PlayerController.instance.transform.position = this.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
