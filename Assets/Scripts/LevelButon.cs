using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelButon : MonoBehaviour
{
    public Image[] starsImage;
    public Sprite yellowstar;

    public void SetStars(int stars)
    {
        for(int i = 0; i < stars; i++)
        {
            starsImage[i].sprite = yellowstar;
        }
    }
}
