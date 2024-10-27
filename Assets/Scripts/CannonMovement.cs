using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonMovement : MonoBehaviour
{
    [SerializeField] public Slider z;
    [SerializeField] public Slider x; 



    void Start()
    {
        SetSliderValue(90, -90, z);
        SetSliderValue(90, 0, x);
    }


    public void SetSliderValue(float maxValue, float minValue, Slider slider)
    {
        slider.value = 0;

        transform.eulerAngles = new Vector3(0, 0, 0);
 
        slider.maxValue = maxValue;
        slider.minValue = minValue;
    }

    public void CannonRotation()
    {
        Quaternion rotation = Quaternion.Euler(x.value, transform.rotation.y, z.value);
        transform.rotation = rotation;
    }
}
