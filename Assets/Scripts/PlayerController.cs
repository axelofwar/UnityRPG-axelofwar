using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D theRB;
    public float moveSpeed; 
    public Animator playerAnim;
    public static PlayerController instance; 
    public string areaTransitionName;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this; //set the instance to the player being controlled by this script every time
        }

        else
        {
            Destroy(gameObject); // if a new instance was made to replicate current then delete old one - on first scene run
        }

        DontDestroyOnLoad(gameObject); //by default game object is attached to whatever object the script runs on
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")) * moveSpeed;
        playerAnim.SetFloat("moveX",theRB.velocity.x);
        playerAnim.SetFloat("moveY",theRB.velocity.y);

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            playerAnim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            playerAnim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }
    }
}
