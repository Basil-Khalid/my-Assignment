using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      //Basil Khalid -_-
      // we generatr 20 numbers excipts number (5) and (15) --> we often do more than 20 loops 
       int counter = 1;
       while(counter <= 20){

         int randonNum = Random.Range(1,21);

         if (randonNum == 5){
            Debug.Log("Note that the num is (5) we skip it");
            continue;
         }
         else if (randonNum == 15){
            Debug.Log("Note that the num is (15) we exit from the loop");
            break;
         }
         Debug.Log(randonNum);

         counter++;

       }
    }

   
}
