using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] private AudioSource smackSoundEffect;

    private void Awake()
    {

        //HelthBarFunction.SetHealthBarValue(PlayerPrefs.GetFloat("health"));
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        //PlayerStats.health = PlayerPrefs.GetFloat("health");
        //Debug.Log(PlayerStats.health);
        Debug.Log(HelthBarFunction.GetHealthBarValue());
        HelthBarFunction.SetHealthBarValue(PlayerPrefs.GetFloat("health"));
        Debug.Log(HelthBarFunction.GetHealthBarValue());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {

            HelthBarFunction.SetHealthBarValue(HelthBarFunction.GetHealthBarValue() - 0.20f);
            Debug.Log(HelthBarFunction.GetHealthBarValue());
            //PlayerStats.health = HelthBarFunction.GetHealthBarValue();

            smackSoundEffect.Play();

            if (HelthBarFunction.GetHealthBarValue() < 0.01f)
            {
                Die();
            }
            
        }
    }

    private void Die()
    {
        deathSoundEffect.Play();
        //HelthBarFunction.SetHealthBarValue(PlayerPrefs.GetFloat("health"));
        //PlayerStats.health = HelthBarFunction.GetHealthBarValue();
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");

    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
