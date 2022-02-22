using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MentalStabilityUI : MonoBehaviour
{
    [SerializeField] private Slider mentalStabilitySlider;
    [SerializeField] private Text mentalStabilityText;
    [SerializeField] private MentalStabilityManager mentalStabilityManager;

    private void Update() {
        UpdateValue(mentalStabilityManager.GetHealth());
    }

    public void UpdateValue(float value)
    {
        mentalStabilityText.text = $"{(int)value} %";
        mentalStabilitySlider.value = value;
    }
}
