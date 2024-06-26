using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterLevel : MonoBehaviour
{
    public Slider slider;

    public void waterAtMinLevel(float level){
        slider.maxValue = level;
        slider.value = level;
    }

    public void setWaterLevel(float level){
        slider.value = level;
    }
}
