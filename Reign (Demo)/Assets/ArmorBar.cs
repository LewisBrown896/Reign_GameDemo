using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorBar : MonoBehaviour
{
    //the components of the armor bar
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    //setting the value of armor to 100
    public void SetMaxArmor(int armor)
    {
        slider.maxValue = armor;
        slider.value = armor;

        fill.color = gradient.Evaluate(1f);
    }

    //the slider will go down after each hit
    public void SetArmor(int armor)
    {
        slider.value = armor;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
