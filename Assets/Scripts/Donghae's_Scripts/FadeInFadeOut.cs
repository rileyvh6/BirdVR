using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInFadeOut : MonoBehaviour
{
    public static FadeInFadeOut current;
    Image blackImage;
    public Color color;
    public float colorA 
    { 
        get 
        {
            return color.a;
        }
        set
        {
            color.a = value;
            if (color.a >= 0.9f)
                BirdMovement.move = false;
            else if(color.a < 0.1f)
                BirdMovement.move = true;
            color.a = colorA;
        }
    }
    public float speed;

    private void Awake()
    {
        blackImage = GetComponent<Image>();
        color = blackImage.color;
        current = this;
    }

    // Start is called before the first frame update
    void Start()
    {
      
        //StartCoroutine(FadeOut());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator FadeToBlack(float cap, float scale)
    {

        while (blackImage.color.a < cap)
        {
            yield return null;
            colorA += speed * Time.deltaTime;
            Vector3 scaleVector3 = new Vector3((2 * scale * Time.deltaTime),1 * scale * Time.deltaTime, 0f);
            blackImage.rectTransform.localScale += scaleVector3;
            blackImage.color = color;
        }
    }

    public IEnumerator FadeToBlack(float cap)
    {
        while (blackImage.color.a < cap)
        {
            yield return null;
            colorA += speed * Time.deltaTime;
            blackImage.color = color;
        }
    }


    public IEnumerator FadeToBlack()
    {
        yield return FadeToBlack(1f);
    }


    public IEnumerator FadeOut()
    {
        while (blackImage.color.a > 0f)
        {
            yield return null;
            colorA -= speed * Time.deltaTime;
            blackImage.color = color;
        }
    }

}
