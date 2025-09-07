using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManuManager : MonoBehaviour
{
    public LevelButon[] levelButtons;

    public GameObject[] lockButtons;


    private void Start()
    {
        //PlayerPrefs.DeleteAll();
        SetMenuStars();
        DeactivateLockButtons();
    }

    private void DeactivateLockButtons()
    {
        int levelsSolved = PlayerPrefs.GetInt("levelsSolved", 0);

        for(int i = 0; i < levelsSolved; i++)
        {
            if(i < lockButtons.Length) 
            {
                lockButtons[i].SetActive(false);
            }
            
        }
    }

    private void SetMenuStars()
    {
        for(int i = 0; i < levelButtons.Length; i++)
        {
            int levelStars = PlayerPrefs.GetInt("level" + (i + 1) + "stars", 0);
            levelButtons[i].SetStars(levelStars);
        }
    }

    public void LoadLevels(string levelName)
    { 
        SceneManager.LoadScene(levelName);
    
    }
   
   

}
