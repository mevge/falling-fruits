using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class childTriggger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Peach") || other.gameObject.CompareTag("Pineapple") || other.gameObject.CompareTag("Strawberry"))
        {
            SceneManager.LoadScene("Scene04");
        }
    }
}