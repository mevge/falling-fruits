using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroyer : MonoBehaviour
{
    Score score;
    AudioSource audSrc;
    public AudioClip Aud1, Aud2;

    void Start()
    {
        score = FindObjectOfType<Score>();
        audSrc = GetComponent<AudioSource>();
        DeleteInt();

    }

    void Update()
    {
        //Scene02(Main) is processing
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            //This code blocks for increasing process
            if (hit.collider != null && hit.collider.tag == "Peach")
            {
                score.count++;
                audSrc.PlayOneShot(Aud1);
                Destroy(hit.collider.gameObject);
            }
            else if (hit.collider != null && hit.collider.tag == "Strawberry")
            {
                score.count++;
                audSrc.PlayOneShot(Aud1);
                Destroy(hit.collider.gameObject);

            }
            else if (hit.collider != null && hit.collider.tag == "Pineapple")
            {
                score.count++;
                audSrc.PlayOneShot(Aud1);
                Destroy(hit.collider.gameObject);
            }

            //This code blocks for losing game process
            else if (hit.collider != null && hit.collider.tag == "rotApple")
            {
                audSrc.PlayOneShot(Aud2);
                SceneManager.LoadScene("Scene03");
            }
            else if (hit.collider != null && hit.collider.tag == "rotPear")
            {
                audSrc.PlayOneShot(Aud2);
                SceneManager.LoadScene("Scene03");
            }
            else if (hit.collider != null && hit.collider.tag == "rotOrange")
            {
                audSrc.PlayOneShot(Aud2);
                SceneManager.LoadScene("Scene03");
            }
        }
    }

    //Destroying objects when out of screen
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


    public void DeleteInt()
    {
        //This line collecting total score
        PlayerPrefs.DeleteKey("highscore");
    }
}



