using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    int i = 0;
    private int nextSceneToLoad;

    private void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        i++;
        if (i == 3)
        {
            if (other.gameObject.tag == "Mermi")
            {
                SceneManager.LoadScene("History");
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("degdi");
        
        if (collision.gameObject.tag == "pirireis")
        {
            
            if (nextSceneToLoad == 7)
            {
                SceneManager.LoadScene(0);
            }
            else 
            {
                SceneManager.LoadScene(nextSceneToLoad);
            }
        }

        
        i++;
        if (i == 3)
        {
            if (collision.gameObject.tag == "Mermi")
            {
                SceneManager.LoadScene("History");
            }
        }
       
    }
}
