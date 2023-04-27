using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Здоровье присваивает
    public int health = 5;

    //Уровень НПС
    public int level = 1;

    //Скорость НПС
    public float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
       //Прибавляет здоровье к уровню
       health += level;
       //Отправляет уведомление в консоль
       print(health);


    }

    // Update is called once per frame
    void Update()
    {
      Vector3 newPosition = transform.position;
       newPosition.z += speed * Time.deltaTime;
       transform.position = newPosition;  
    }
}
