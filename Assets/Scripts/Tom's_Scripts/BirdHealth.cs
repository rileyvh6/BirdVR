using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BirdHealth : MonoBehaviour
{
    /*
    public int startHealth = 1;
    public int currentHealth;
    public Image damageImage;
    public AudioClip deathClip;

    Animator anim;
    AudioSource playerAudio;
    PlayerMovement playerMovement;
    public GameOverManager gameOverManagerScript;
    bool isDead;
    bool damaged;

    void Awake()
    {
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        playerMovement = GetComponent<PlayerMovement>();
        currentHealth = startingHealth;
    }

    void Update()
    {
        if (damaged)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
    }

    public void TakeDamage(int amount)
    {
        damaged = true;

        currentHealth -= amount;
        healthSlider.value = currentHealth;
        playerAudio.Play();

        Death();
    }

    void Death()
    {
        isDead = true;
        gameOverManagerScript.GameOver();

        anim.SetTrigger("Die");

        playerAudio.clip = deathClip;
        playerAudio.Play();

        playerMovement.enabled = false;
    }
    */
}

