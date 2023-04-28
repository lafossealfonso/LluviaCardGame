using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCard : MonoBehaviour
{
    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private int numCards = 2;
    [SerializeField] private float cardSpacing = 0.5f;
    [SerializeField] private float tiltAngle = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numCards; i++)
        {
            //instantiates card for every number in numCards.
            GameObject card = Instantiate(cardPrefab, transform);
            card.transform.localPosition = new Vector3(i * cardSpacing, 0, 0);

            //tilt cards
            float angle = (i - (numCards - 1) / 2.0f) * tiltAngle;
            card.transform.Rotate(Vector3.back, angle);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void DrawCardToHand()
    {
        numCards++;

        for (int i = 0; i < numCards; i++)
        {
            //instantiates card for every number in numCards.
            GameObject card = Instantiate(cardPrefab, transform);
            card.transform.localPosition = new Vector3(i * cardSpacing, 0, 0);

            //tilt cards
            float angle = (i - (numCards - 1) / 2.0f) * tiltAngle;
            card.transform.Rotate(Vector3.back, angle);
        }

        
    }
}
