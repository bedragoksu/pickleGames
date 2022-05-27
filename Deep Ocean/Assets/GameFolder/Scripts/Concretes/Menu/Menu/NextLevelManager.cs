using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevelManager : MonoBehaviour
{
    public int buildIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        buildIndex = SceneManager.GetActiveScene().buildIndex;
        Text levelText = GameObject.Find("LevelText").GetComponent<Text>();
        levelText.text = "Level " + (buildIndex-1).ToString();
    }

    public void NextLevel()
    {
        int saveIndex = PlayerPrefs.GetInt("SaveIndex");
        if (buildIndex>saveIndex)
        {
            PlayerPrefs.SetInt("SaveIndex",buildIndex);
        }
        if(buildIndex == 6)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(buildIndex + 1);
        }
    }


}
