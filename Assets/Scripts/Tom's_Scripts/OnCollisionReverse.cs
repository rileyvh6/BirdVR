using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionReverse : MonoBehaviour
{
    /*
    Rigidbody rb;
    [SerializeField] GameObject dummyObj;
    [SerializeField] GameObject player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            rb.isKinematic = false;
            ContactPoint contact = collision.contacts[0];
            Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, contact.normal);
            dummyObj.transform.position = contact.point;
            dummyObj.transform.rotation = rotation;
            dummyObj.transform.eulerAngles = new Vector3(dummyObj.transform.eulerAngles.x, dummyObj.transform.eulerAngles.y, 0f);
            dummyObj.transform.position += Vector3.forward * 10f;
            Debug.Log("Ow");
            StartCoroutine(LerpCo());
        }
    }

    IEnumerator LerpCo()
    {
        while(true)
        {
            yield return null;
            player.transform.position = Vector3.Lerp(player.transform.position, dummyObj.transform.position, Time.deltaTime * speed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */   
}

// Have camera lerp towards the point using private object
// Disable movement when lerping, lerp then resume
// Implement fade to black (quick fade)
// Triangulate the tree
//TODO Have a time where it stops