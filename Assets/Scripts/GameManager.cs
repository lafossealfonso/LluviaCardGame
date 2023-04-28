using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int currentExcitementValue = 100;
    public float targetExcitementValue = 100;
    public Slider excitementSlider;

   
    public float speed = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        excitementSlider.value = currentExcitementValue;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        excitementSlider.value = targetExcitementValue;

        targetExcitementValue -= Time.deltaTime * speed;

        if (currentExcitementValue >= targetExcitementValue)
        {
            targetExcitementValue = currentExcitementValue;
        }
    }
    



}
