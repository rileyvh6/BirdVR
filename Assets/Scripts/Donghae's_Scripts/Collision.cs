using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public static Collision current;
    public GameObject VrManger;
    public GameObject startPoint;

    private  void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            BirdMovement.move = false;
            StartCoroutine(FadeInFadeOut.current.FadeToBlack());
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);
        VrManger.transform.position = startPoint.transform.position;
        //VrManger.transform.rotation = startPoint.transform.rotation;
        yield return FadeInFadeOut.current.FadeOut();
    }
}
