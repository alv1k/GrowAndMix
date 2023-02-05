using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//вода и удобрения
//сено и сахарная вата
//пена для ванны и молоко
//чай и петрушка
//вода из лужи и прокисший квас
//мука и помидор
//перья и птичье молоко
//ртуть и клей
//жвачка и перец

public class BagScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int item1;
    public int item2;

    [SerializeField] TextMeshProUGUI ingr1;
    [SerializeField] TextMeshProUGUI ingr2;


    public int reciept = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(item1==0 && item2==0){
            ingr1.text = "Ингредиент1";
            ingr2.text = "Ингредиент2";
        }else if(item1==1 && item2==0){
            print("Есть вода, нужно найти что-то, на чем всё растет");
            ingr1.text = "Вода в стакане";
            if(item1 == 1 && item2 == 1){
                print("Пора готовить зелье");
                reciept = 1;//udo&water
            }
        }else if(item2==1 && item1==0){
            print("Есть удобрения, нужно найти чем-то полить это всё");
            ingr2.text = "Кулачок с удобрениями";
            if(item2 == 1 && item1==1 ){   
                print("Пора готовить зелье");
                reciept = 1;//udo&water
            }
        }else if(item2==1 && item1==1){
            print("Пора готовить зелье");
            reciept = 1;//udo&water
        }
        

        
    }
}