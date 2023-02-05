using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class handController : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;

    GameObject PressE;
    GameObject Action;
    GameObject Result;
    GameObject instagram;
    GameObject godDamn;
    GameObject PressEColb;
    
    GameObject hand;
    GameObject Water;
    GameObject Udobreniya;
    GameObject Seno;
    GameObject SakhamnayaVata;

    Transform handTR;
    Transform waterTR;
    Transform udoTR;
    Transform SenoTr;
    Transform SakhamnayaVataTr;


    //


    [SerializeField] TextMeshProUGUI ingrNames;
    public BagScript bagContr;
    
    
//вода и удобрения
//сено и сахарная вата
//пена для ванны и молоко
//чай и петрушка
//вода из лужи и прокисший квас
//мука и помидор
//перья и птичье молоко
//ртуть и клей
//жвачка и перец

    
    

    

    void Start()
    {
        PressE = GameObject.Find("PressE");
        Action = GameObject.Find("Action");
        Result = GameObject.Find("Result");
        instagram = GameObject.Find("instagram");
        godDamn = GameObject.Find("godDamn");
        PressEColb = GameObject.Find("PressEColb");


        Water = GameObject.Find("Water");
        hand = GameObject.Find("hand");
        Udobreniya = GameObject.Find("Udobreniya");
        Seno = GameObject.Find("Seno");
        SakhamnayaVata = GameObject.Find("SakhamnayaVata");
        
        PressE.SetActive(false);
        Action.SetActive(false);
        Result.SetActive(false);
        instagram.SetActive(false);
        godDamn.SetActive(false);
        PressEColb.SetActive(false);



        handTR = hand.GetComponent<Transform>();
        waterTR = Water.GetComponent<Transform>();
        udoTR = Udobreniya.GetComponent<Transform>();
        SenoTr = Seno.GetComponent<Transform>();
        SakhamnayaVataTr = SakhamnayaVata.GetComponent<Transform>();

        //TextComponent = GetComponent<TextMeshPro>();
        
        //TextComponent = GetComponent<TMP_Text>();

    }

    // Update is called once per frame
    void Update()
    {
        PressE.SetActive(false);
        Action.SetActive(false);
        //Result.SetActive(false);
        PressEColb.SetActive(false);

        Debug.DrawRay(cam.transform.position, cam.transform.forward * 40f, Color.red);
        RaycastHit touch;

        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out touch, 40)){
            if(touch.transform.gameObject.tag == "water"){
                PressE.SetActive(true);
                if(Input.GetKeyDown("e")){
                    //print(touch.transform.gameObject.name);
                    // if(gameObject.name);
                    waterTR.position = handTR.position;
                    waterTR.rotation = handTR.rotation;
                    waterTR.SetParent(handTR);
                    bagContr.item1 = 1;
                }

            }
            if(touch.transform.gameObject.tag == "udo"){
                PressE.SetActive(true);
                if(Input.GetKeyDown("e")){
                    //print(touch.transform.gameObject.name);
                    // if(gameObject.name);
                    udoTR.position = handTR.position;
                    udoTR.rotation = handTR.rotation;
                    udoTR.SetParent(handTR);
                    bagContr.item2 = 1;
                }
            }
            if(touch.transform.gameObject.tag == "vata"){//TUT
                PressE.SetActive(true);
                if(Input.GetKeyDown("e")){
                    //print(touch.transform.gameObject.name);
                    // if(gameObject.name);
                    waterTR.position = handTR.position;
                    waterTR.rotation = handTR.rotation;
                    waterTR.SetParent(handTR);
                    bagContr.item1 = 1;
                }

            }
            if(touch.transform.gameObject.tag == "seno"){
                PressE.SetActive(true);
                if(Input.GetKeyDown("e")){
                    //print(touch.transform.gameObject.name);
                    // if(gameObject.name);
                    udoTR.position = handTR.position;
                    udoTR.rotation = handTR.rotation;
                    udoTR.SetParent(handTR);
                    bagContr.item2 = 1;
                }
            }
            if(touch.transform.gameObject.tag == "colb1"){         
                if(bagContr.reciept==0){
                    print("Нечего смешивать");
                    //                    
                }
                if(bagContr.reciept==1){
                    if(touch.transform.gameObject.tag == "colb1"){
                        //подсказка что можно смешать в этой колбе
                        PressEColb.SetActive(true);

                        if(Input.GetKeyDown("e")){
                            bagContr.item1 = 0;
                            bagContr.item2 = 0;
                            Result.SetActive(true);
                            print("На моей голове выросли заросли камыша");
                            if(bagContr.item1 == 0 && bagContr.item2 == 0){
                                bagContr.reciept=0;
                            }
                        }
                        
                    }
                }else if(bagContr.reciept==2){
                    if(touch.transform.gameObject.tag == "colb1"){
                        //подсказка что можно смешать в этой колбе
                        PressEColb.SetActive(true);

                        if(Input.GetKeyDown("e")){
                            bagContr.item1 = 0;
                            bagContr.item2 = 0;
                            Result.SetActive(true);
                            print("На моей голове выросли кудри как у Павла Артемьева!");
                            print("Я парень что надо. Теперь для меня нет абсолютно никаких границ!");
                            if(bagContr.item1 == 0 && bagContr.item2 == 0){
                                bagContr.reciept=0;
                            }
                        }
                        
                    }
                }
            }
            
        }

        if(bagContr.reciept==1){
            Action.SetActive(true);
            ingrNames.text = "эти удобрения и воду, намажемся и подождем пару секунд";
            if(bagContr.reciept==0){
                Action.SetActive(false);   
            }

            
        }
        if(bagContr.reciept==2){
            Action.SetActive(true);
            ingrNames.text = "эти сено и сахарную вату, намажемся и подождем пару секунд";
            if(bagContr.reciept==0){
                Action.SetActive(false);   
            }
        }
    }
}
