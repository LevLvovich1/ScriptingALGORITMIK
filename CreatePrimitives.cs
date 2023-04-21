using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrimitives : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       //Создает модель Стива MINECRAFT
       GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3(0, 0, 0);
       GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 1, 0);
       GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3(0.5f, 1, 0);
       GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3(0.5f, 2, 0);
       GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 2, 0);
       GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3(0, 3, 0);
       //Печатает в консоль текст: Stive in HERE
       print("Stive In HERE");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

