using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int gold;
    public int enemiesDefeatedCount;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI enemiesDefeatedCountText;

    public Sprite[] backgrounds;
    private int currentBackground;
    private int enemiesUntilBackgroundChange;
    public Image backgroundImage;


    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        enemiesUntilBackgroundChange = 5;
        enemiesDefeatedCount = 0;
    }

    public void AddGold(int amount)
    {
        gold += amount;

        UpdateUI();
    }

    public void TakeGold(int amount)
    {
        gold -= amount;

        UpdateUI();
    }

    public void IncreaseEnemyDefeatedCount(int amount)
    {
        enemiesDefeatedCount += amount;

        UpdateUI();
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

    public void UpdateUI()
    {
        goldText.text = "Gold: " + gold.ToString();
        enemiesDefeatedCountText.text = "Enemies Defeated: " + enemiesDefeatedCount.ToString();
    }
}
