using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript1 : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("degdi");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("degdi");
            SceneManager.LoadScene("Level_3");
        }
    }
}
