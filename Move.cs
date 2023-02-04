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
