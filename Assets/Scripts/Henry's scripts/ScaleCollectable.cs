using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCollectable : MonoBehaviour
{
    [SerializeField]
    public int points = 10;
    [SerializeField]
    public bool collected;
    [SerializeField] public Transform player;
    private Vector3 startSize;
    private Vector3 endSize = new Vector3(1.25f, 1.25f, 1.25f);

    bool growing = true;
    public float scale = 1;

    void Start()
    {
        startSize = transform.localScale;
        endSize += startSize;
    }

    protected void FixedUpdate()
    {
        if (growing)
        {
            transform.localScale = Vector3.Lerp(startSize , endSize, (Mathf.Sin(1f * Time.time) + 1.0f) / 2.0f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            growing = false;
        }

        if (other.tag == "Player")
        {
            ScoreManager.score += points;
            Destroy(gameObject);
        }
    }
}
