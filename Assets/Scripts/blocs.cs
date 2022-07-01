using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocs : MonoBehaviour
{
    int[] positionsCube = new int[] { -45, 5, 70 };
    int ligneGap = 50;
    int[] scaleCube = new int[] { 10, 10, 10 };
    List<GameObject> cubes = new List<GameObject>();
    Color colorCube = Color.red;
    float speedCube = 20;
    float multipleSpeedCube = 1.05f;
    float limitSpeed = 1.5f;
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
                cubes.Add(GameObject.CreatePrimitive(PrimitiveType.Cube));
                cubes[position].transform.localScale = new Vector3(scaleCube[0], scaleCube[1], scaleCube[2]);
                cubes[position].transform.localPosition = new Vector3(positionsCube[0] + positionMultiple, positionsCube[1], positionsCube[2]);
                cubes[position].GetComponent<MeshRenderer>().material.color = colorCube;
                cubes[position].AddComponent<BoxCollider>();
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
                cubes.Add(GameObject.CreatePrimitive(PrimitiveType.Cube));
                cubes[position].transform.localScale = new Vector3(scaleCube[0], scaleCube[1], scaleCube[2]);
                cubes[position].transform.localPosition = new Vector3(positionsCube[0] + positionMultiple, positionsCube[1], positionsCube[2] + ligneGap);
                cubes[position].GetComponent<MeshRenderer>().material.color = colorCube;
                cubes[position].AddComponent<BoxCollider>();
                position++;
            }

              positionMultiple += 10;



        }
    }

    void Update()
    {

        foreach (GameObject cube in cubes)
        {
            cube.transform.Translate(((-Vector3.forward) * Time.deltaTime) * speedCube);
        }

        if (cubes[0].transform.position.z < -50)
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
                    cubes[position] = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cubes[position].transform.localScale = new Vector3(scaleCube[0], scaleCube[1], scaleCube[2]);
                    cubes[position].transform.localPosition = new Vector3(positionsCube[0] + positionMultiple, positionsCube[1], positionsCube[2]);
                    cubes[position].GetComponent<MeshRenderer>().material.color = colorCube;
                    cubes[position].AddComponent<BoxCollider>();

                    position++;

                }
                positionMultiple += 10;
            }

        }

        if (cubes[9].transform.position.z < -50)
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
                    cubes[position] = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cubes[position].transform.localScale = new Vector3(scaleCube[0], scaleCube[1], scaleCube[2]);
                    cubes[position].transform.localPosition = new Vector3(positionsCube[0] + positionMultiple, positionsCube[1], positionsCube[2]);
                    cubes[position].GetComponent<MeshRenderer>().material.color = colorCube;
                    cubes[position].AddComponent<BoxCollider>();
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