using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class FunnySentenceGenerator : MonoBehaviour
{
    
    void Start()
    {
    string[] funnyArray = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
    string sentence = ""; 
    int counter = 0;

        while (counter < 7)
        {
            int funnyIndex = Random.Range(0, funnyArray.Length);
            sentence += funnyArray[funnyIndex] + " "; 
            counter++;
        }

    Debug.Log(sentence); 
    }


    
}
