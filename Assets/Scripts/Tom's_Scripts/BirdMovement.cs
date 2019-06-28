using UnityEngine;
using System.Collections;

public class BirdMovement : MonoBehaviour
{
    public float speed;
    static public bool move = true;
    Vector3 movement;
    Animator anim; 
    Rigidbody birdRigidbody;  


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(move)
            transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
    }

}
