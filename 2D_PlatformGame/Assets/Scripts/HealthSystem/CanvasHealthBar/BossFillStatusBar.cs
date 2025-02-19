using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BossFillStatusBar : MonoBehaviour
{
    public BossHealthStatus healthStatus;

    public Image fillImage;

    public Color fillColor = Color.green;
    public Color lowHealthColor = Color.red;

    private Slider slider;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }

    private void Update()
    {
        if (slider.value <= slider.minValue)
        {
            fillImage.enabled = false;
            slider.gameObject.gameObject.SetActive(false);
        }

        if (slider.value > slider.minValue && !fillImage.enabled)
            fillImage.enabled = true;

        //obliczenie procentu wype�nienia slidera �ycia
        float fillValue = (float)healthStatus.health / (float)healthStatus.maxHealth;

        //je�li �ycie spada poni�ej 1/3 to kolor wype�nienia si� zmienia
        if (fillValue <= slider.maxValue / 3)
            fillImage.color = lowHealthColor;
        else if (fillValue > slider.maxValue / 3)
            fillImage.color = fillColor;

        //ustawienie warto�ci na sliderze
        slider.value = fillValue;
    }
}
