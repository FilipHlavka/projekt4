using System.Collections.Generic;
using UnityEngine;


public class boxPosition : Pozice
{

    public override List<Vector3> makeMath(Vector3 startPosition, List<Movement> unitsList) {


        double x = Mathf.Round(Mathf.Sqrt(unitsList.Count));
        //Debug.Log(x);
        int k = 0;
        for (int i = 0; i <= x; i++)
        {
           
            for (int j = 0; j < x && k < unitsList.Count; j++)
            {
               
                newPositions.Add(new Vector3(startPosition.x + i * 5, 0, startPosition.z + j * 5));
                k++;
                //Debug.Log($"{unitsList[j].name} {newPositions[j]} ");

            }
        }

        return newPositions; 


     }
}