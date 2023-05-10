using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RaycastClick : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Perform raycast
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // Check if hit object has a CardObject component
                CardObject cardObject = hit.collider.gameObject.GetComponent<CardObject>();
                if (cardObject != null)
                {
                    Debug.Log(cardObject);
                    // Destroy the CardObject
                    Destroy(cardObject);
                }
            }
        }
    }
}
