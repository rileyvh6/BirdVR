using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField]
    public int points = 10;
    [SerializeField]
    public bool collected;
    [SerializeField] public Transform player;

    //protected Transform player;

    /*void Start()
    {
        if(tag != "Collectable")
        {
            tag = "Collectable";
        }
        GetComponent<Collider>().isTrigger = true;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }*/

    void OnTriggerEnter (Collider other)
    {
      if(other.tag == "Player")
        {
            ScoreManager.score += points;
            CoinGet();
        }
    }

    void CoinGet()
    {

        Destroy(gameObject);

    }
}
