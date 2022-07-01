using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocs : MonoBehaviour
{
    float[] positionsCube = new float[] { -45, 6, 70 };
    int ligneGap = 48;

    public GameObject cube;
    List<GameObject> cubes = new List<GameObject>();
    float speedCube = 2000;
    float multipleSpeedCube = 1.2f;
    float limitSpeed = 9000;
    void Start()
    {
        int position = 0;
        int positionMultiple = 0;
        int random1 = Random.Range(0, 10);
        int random2 = Random.Range(0, 10);

        while (random1 == random2)
        {
            random2 = Random.Range(0, 10);
        }

        for (int index = 0; index < 10; index++)
        {


            if (index != random1 && index != random2)
            {
                cubes.Add(Instantiate(cube, new Vector3(positionsCube[0] + positionMultiple, positionsCube[1],  positionsCube[2]), Quaternion.identity));
                position++;
            }

            positionMultiple += 10;


        }
        random1 = Random.Range(0, 10);
        random2 = Random.Range(0, 10);
        positionMultiple = 0;
        while (random1 == random2)
        {
            random2 = Random.Range(0, 10);
        }

        for (int index = 0; index < 10; index++)
        {

            if (index != random1 && index != random2)
            {
                cubes.Add(Instantiate(cube, new Vector3(positionsCube[0] + positionMultiple, positionsCube[1],  positionsCube[2] + ligneGap), Quaternion.identity));
                position++;
            }

              positionMultiple += 10;



        }
    }

    void Update()
    {

        foreach (GameObject cube in cubes)
        {
            cube.GetComponent<Rigidbody>().velocity = Vector3.back  * Time.deltaTime * speedCube;
        }

        if (cubes[0].transform.position.z < -52)
        {
            int position = 0;
            int positionMultiple = 0;
            int random1 = Random.Range(0, 10);
            int random2 = Random.Range(0, 10);

            while (random1 == random2)
            {
                random2 = Random.Range(0, 10);
            }

            for (int index = 0; index < 10; index++)
            {
                if (index != random1 && index != random2)
                {
                    Destroy(cubes[position]);
                    cubes[position] = Instantiate(cube,
                        new Vector3(positionsCube[0] + positionMultiple, positionsCube[1], positionsCube[2]),
                        Quaternion.identity);

                    position++;

                }
                positionMultiple += 10;
            }

        }

        if (cubes[9].transform.position.z < -52)
        {
            int position = 8;
            int positionMultiple = 0;
            int random1 = Random.Range(0, 10);
            int random2 = Random.Range(0, 10);

            while (random1 == random2)
            {
                random2 = Random.Range(0, 10);
            }

            for (int index = 0; index < 10; index++)
            {
                if (index != random1 && index != random2)
                {
                    Destroy(cubes[position]);
                    cubes[position] = Instantiate(cube,
                        new Vector3(positionsCube[0] + positionMultiple, positionsCube[1], positionsCube[2]),
                        Quaternion.identity);
                    position++;

                }
                 positionMultiple += 10;
            }

            if (speedCube < limitSpeed)
            {
                speedCube = (float)(speedCube * multipleSpeedCube);
            }
        }

    }

}