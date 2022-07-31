using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;
    //private ItemCollector itemCollector;    

    private bool levelCompleted = false;

    // Start is called before the first frame update
    void Start()
    {
        finishSound = GetComponent<AudioSource>();
        //itemCollector = GetComponent<ItemCollector>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            finishSound.Play();
            //Debug.Log(itemCollector.cherries);
            //PlayerPrefs.SetInt("cherries", itemCollector.cherries);
            levelCompleted = true;
            Invoke("CompleteLevel", 2f);

        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
