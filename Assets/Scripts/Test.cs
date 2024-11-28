using UnityEngine;

public class Test : MonoBehaviour
{
    const int SIZE = 4096;
    void Start()
    {
        // Prepare Data
        int [] myInts = new int [ SIZE * SIZE ];
        for (int i = 0; i < myInts.Length; i++)
        {
            myInts[i] = Random.Range(0, 255);
        }

        // V2
        int[,] my2Dints = new int [SIZE, SIZE];
        for (int x = 0; x < SIZE; x++)
        {
            for (int y = 0; y < SIZE; y++)
            {
                my2Dints[x, y] = Random.Range(0, 255);
            }
        }

        // Start measurement
        System.DateTime start = System.DateTime.Now;

        // Do something
        long totalRed = 0; // Fast
        // long totalRed_2 = 0; // Slow
        for (int x = 0; x < SIZE; x++)
        {
            for (int y = 0; y < SIZE; y++)
            {
                int i_1 = x * SIZE + y; // Calculation of the index of in a single array while being two dimensional

                // if(x == 0 && y < 10) Debug.Log(i_1);
                
                totalRed += myInts[i_1];
            }
        }

        // End measurement
        System.TimeSpan duration = System.DateTime.Now - start;
        Debug.Log(string.Format("Time spent: {0} milliseconds V1:", duration.TotalMilliseconds));

        start = System.DateTime.Now;

        // Do something V2
        totalRed = 0;
        for (int x = 0; x < SIZE; x++)
        {
            for (int y = 0; y < SIZE; y++)
            {
                totalRed += my2Dints[x, y];
            }
        }

        // End measurement V2
        System.TimeSpan duration2 = System.DateTime.Now - start;
        Debug.Log(string.Format("Time spent: {0} milliseconds V2: ", duration2.TotalMilliseconds));


        Debug.Log(string.Format("Total value of reds is: {0}", totalRed));        
    }

    void Update()
    {
        
    }
}
