using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatform : MonoBehaviour
{
    public GameObject platform;
    public float fadeOutTime = 1.0f;
    public float fadeInTime = 2.0f;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            platform.GetComponent<Animator>().SetBool("FadeOut", true);
            StartCoroutine(FadeOut());
        }
    }

    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(fadeOutTime);
        platform.SetActive(false);
        platform.GetComponent<Animator>().SetBool("FadeOut", false);
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(fadeInTime);
        platform.SetActive(true);
    }
}
