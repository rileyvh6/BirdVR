using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    [SerializeField] GameObject player;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            player.GetComponent<BirdMovement>().speed =20;
            StartCoroutine(BackNormal());
            Destroy(other.gameObject);
        }
    }

    IEnumerator BackNormal()
    {
        yield return new WaitForSeconds(6);
        player. GetComponent<BirdMovement>().speed = 10;
    }
}