using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp_Flight : MonoBehaviour
{

    [SerializeField]
    Transform LerpTarget;
    [SerializeField]
    Transform rotation;
    private Vector3 Point;
    [SerializeField]
    float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = LerpTarget.transform.position;
        this.transform.position = Vector3.Lerp(this.transform.position, LerpTarget.transform.position, Time.deltaTime * speed);
        transform.rotation = Quaternion.Euler(new Vector3(rotation.rotation.eulerAngles.x, rotation.rotation.eulerAngles.y, transform.rotation.z));
 
    }
}
