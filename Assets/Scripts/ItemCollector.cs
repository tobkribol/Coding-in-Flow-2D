using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemCollector : MonoBehaviour
{

    private Animator anim;

    [SerializeField] private Text cherriesText;
    [SerializeField] private Text melonText;
    [SerializeField] private AudioSource collectionSoundEffect;
    [SerializeField] private AudioSource collection2SoundEffect;
    [SerializeField] private Animation collectionAnimation;

    
    private void Start()
    {
        anim = GetComponent<Animator>();
        Items.cherries = PlayerPrefs.GetInt("cherries");
        cherriesText.text = "Cherries: " + Items.cherries;
        Items.melon = PlayerPrefs.GetInt("melon");
        melonText.text = "Melon: " + Items.melon;
        Debug.Log(Items.cherries + " and " + Items.melon);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            Items.cherries++;
            cherriesText.text = "Cherries: " + Items.cherries;
        }

        if (collision.gameObject.CompareTag("Melon"))
        {
            collection2SoundEffect.Play();
            Destroy(collision.gameObject);
            Items.melon++;
            melonText.text = "Melon: " + Items.melon;
        }
    }
}
