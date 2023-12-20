using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delay = 2f;
    [SerializeField] ParticleSystem particleEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            Invoke("ReloadScene", delay);
            GetComponent<AudioSource>().Play();
            particleEffect.Play();
        }
    }
    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
