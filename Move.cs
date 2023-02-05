using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    Transform playerBody;
    CharacterController contr;

    public float speed = 12f;
    void Start()
    {
        playerBody = GetComponent<Transform>();
        contr = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        float mouseX = Input.GetAxis("Mouse X") * 2;
        float vertical = Input.GetAxis("Vertical");



        contr.Move(playerBody.forward * vertical * speed * Time.deltaTime);
        playerBody.Rotate(0,mouseX,0);

        //Vector3 move = Vector3(Input.GetAxis("Horizontal", 0 ,Input.GetAxis("Vertical")));
        
        //contr.Move(playerBody.forward * vertical * speed * Time.deltaTime);


        //float horizontal = Input.GetAxis("Horizontal");
        contr.Move(playerBody.right * speed * horizontal * Time.deltaTime);   
       
        
        //блок - смотреть назад
        // mouseY = Mathf.Clamp(mouseX, -90f, 90f);
        // playerBody.localRotation = Quaternion.Euler(mouseX,mouseY,0);


        

    }
}


    // public float speed = 6.0F; //Скорость передвижения
    // public float jumpSpeed = 8.0F; //Начальная скорость прыжка
    // public float gravity = 20.0F; //Сила гравитации
    // private Vector3 moveDirection = Vector3.zero; //Направление персонажа
    // void Update() {
    //     CharacterController controller = GetComponent<CharacterController>(); //Берем наш CharacterController
    //     if (controller.isGrounded) { //В нем есть переменная, которая дает знать, стоит ли он на земле. И если он стоит...
    //         moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); //Берем значения кнопок WASD или стрелочек и создаем вектор, указывающий в нужную сторону
    //         moveDirection = transform.TransformDirection(moveDirection); //Переводим локальные координаты в соответствующие глобальные
    //         moveDirection *= speed; //moveDirection - это коэффициент скорости. Поэтому мы умножаем его на максимальную скорость, чтобы получить текущую
    //         if (Input.GetButton("Jump")) //Если мы нажимаем пробел
    //             moveDirection.y = jumpSpeed; //Мы придаем скорости прыжка
           
    //     }
    //     moveDirection.y -= gravity * Time.deltaTime; //Это действие гравитации
    //     controller.Move(moveDirection * Time.deltaTime); //И получив все данные в конце-концов мы вызываем переменную Move и даем ей наш вектор направления. И она сама будет двигать нашего персонажа как надо. Без прохождений сквозь стены, без addForce и прочей ереси.
    // }
 