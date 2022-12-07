using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern
{
    public class Flyweight : MonoBehaviour
    {
        //Create list to store the rocks
        List<Rock> allRocks = new List<Rock>();

        List<Vector2> rockPosition;
        

        public GameObject rockPrefab;

        void Start()
        {
            rockPosition = GetPositions();
            
            for(int i = 0; i <= 10; i++)
            {
                Rock newRock = new Rock();

                newRock.rockPosition = rockPosition;
                
                
                allRocks.Add(newRock);
                Instantiate(rockPrefab, new Vector3((rockPosition[i].x)*20, 0.75f, (rockPosition[i].y)*20),new Quaternion(0,0,0,0));
            }
        }

        //Create a way to get the positions
        List<Vector2> GetPositions()
        {
            List<Vector2> Positions = new List<Vector2>();

            for (int i = 0; i <= 10; i++)
            {
                Positions.Add(new Vector2(Random.value,Random.value));
                
            }
            return Positions;
        }
    }
}