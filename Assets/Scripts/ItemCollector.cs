using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int cherries = 0;
    private int melon = 0;
    private Animator anim;

    [SerializeField] private Text cherriesText;
    [SerializeField] private Text melonText;
    [SerializeField] private AudioSource collectionSoundEffect;
    [SerializeField] private AudioSource collection2SoundEffect;
    [SerializeField] private Animation collectionAnimation;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "Cherries: " + cherries;

        }

        if (collision.gameObject.CompareTag("Melon"))
        {
            collection2SoundEffect.Play();
            Destroy(collision.gameObject);
            melon++;
            melonText.text = "Melon: " + melon;

        }
    }
}
