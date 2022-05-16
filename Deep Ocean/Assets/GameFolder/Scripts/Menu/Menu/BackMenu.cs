using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackMenu : MonoBehaviour
{
    public void BackMainMenu()
    {
        SceneManager.LoadScene(0); // (SceneManager.GetActiveScene().bulildIndex + 1);
    }

}
