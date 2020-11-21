using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider vida;
    public Gradient variacao;
    public Image fill;

    public void SetMaxHealth(int health)
    {
        vida.maxValue = health;
        vida.value = health;

        fill.color = variacao.Evaluate(1f);
    }

    public void SetHealht(int health)
    {
        vida.value = health;

        fill.color = variacao.Evaluate(vida.normalizedValue);
    }
}
