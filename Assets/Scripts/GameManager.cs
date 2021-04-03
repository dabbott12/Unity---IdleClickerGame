using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int gold;
    public TextMeshProUGUI goldText;

    public Sprite[] backgrounds;
    private int currentBackground;
    private int enemiesUntilBackgroundChange;
    public Image backgroundImage;


    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        enemiesUntilBackgroundChange = 5;
    }

    public void AddGold(int amount)
    {
        gold += amount;

        goldText.text = "Gold: " + gold.ToString();
    }

    public void TakeGold(int amount)
    {
        gold -= amount;
        goldText.text = "Gold:" + gold.ToString();
    }

    public void BackgroundCheck()
    {
        enemiesUntilBackgroundChange--;

        if(enemiesUntilBackgroundChange == 0)
        {
            enemiesUntilBackgroundChange = 5;

            currentBackground++;

            if (currentBackground == backgrounds.Length)
            {
                currentBackground = 0;
            }

            backgroundImage.sprite = backgrounds[currentBackground];
        }
    }
}
