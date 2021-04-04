using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickManager : MonoBehaviour
{
    public List<float> autoClickersLastTime = new List<float>();
    public int autoClickerPrice;
    public TextMeshProUGUI autoClickerText;

    private void Update()
    {
        for (int i = 0; i < autoClickersLastTime.Count; i++)
        {
            if (Time.time - autoClickersLastTime[i] >= 1.0f)
            {
                autoClickersLastTime[i] = Time.time;

                EnemyManager.instance.currentEnemy.Damage();
            }
        }
    }

    public void OnBuyAutoClicker()
    {
        if (GameManager.instance.gold >= autoClickerPrice)
        {
            GameManager.instance.TakeGold(autoClickerPrice);

            autoClickersLastTime.Add(Time.time);

            autoClickerText.text = "x " + autoClickersLastTime.Count.ToString();
        }
    }
}
