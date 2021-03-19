using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Menu_Animation : MonoBehaviour
{
    public GameObject Home_1;
    public GameObject Insert_2;
    public GameObject Drawing_3;
    public GameObject Design_4;
    public GameObject Change_Screen_5;
    public GameObject Animation_6;
    public GameObject Slide_Show_7;
    public GameObject Censorship_8;
    public GameObject Display_9;
    //-----------------------------------------
    Vector3 Home_vec;
    Vector3 Insert_vec;
    Vector3 Drawing_vec;
    Vector3 Design_vec;
    Vector3 Change_Screen_vec;
    Vector3 Animation_vec;
    Vector3 Slide_Show_vec;
    Vector3 Censorship_vec;
    Vector3 Display_vec;
    //------------------------------------------
    public GameObject Home_Buttoon_1;
    public GameObject Sounyu_Button_2;
    public GameObject Byouga_Button_3;
    public GameObject Dezain_Button_4;
    public GameObject GamenKirikae_Button_5;
    public GameObject Animation_Button_6;
    public GameObject Slide_Show_Button_7;
    public GameObject Kouetu_Button_8;
    public GameObject Hyouji_Button_9;
    //-----------------------------------------
    public GameObject bar_Image;
    //-----------------------------------------
    public Text Home_Text;
    public Text Sounyu_Text;
    public Text Byouga_Text;
    public Text Dezain_Text;
    public Text Gamen_Kirikae_Text;
    public Text Animation_Text;
    public Text Slide_Show_Text;
    public Text Kouetu_Text;
    public Text Hyouji_Text;
    //-----------------------------------------
    float get_Home_posX;
    float get_Insert_posX;
    float get_Drawing_posX;
    float get_Design_posX;
    float get_Change_Screen_posX;
    float get_Animation_posX;
    float get_Slide_Show_posX;
    float get_Censorship_posX;
    float get_Display_posX;
    //-----------------------------------------
    float Home_Buttoon_1_x;
    float Sounyu_Button_2_x;
    float Byouga_Button_3_x;
    float Dezain_Button_4_x;
    float GamenKirikae_Button_5_x;
    float Animation_Button_6_x;
    float Slide_Show_Button_7_x;
    float Kouetu_Button_8_x;
    float Hyouji_Button_9_x;
    //-----------------------------------------
    float bar_Image_y;
    float bar_Image_z;
    //-----------------------------------------
    int Button_num = 1;
    int Button_num_befor = 1;
    //-----------------------------------------
    float bar_Image_Ysize;
    float Home_Text_Xsize;
    float Sounyu_Text_Xsize;
    float Byouga_Text_Xsize;
    float Dezain_Text_Xsize;
    float Gamen_Kirikae_Text_Xsize;
    float Animation_Text_Xsize;
    float Slide_Show_Text_Xsize;
    float Kouetu_Text_Xsize;
    float Hyouji_Text_Xsize;
    //-----------------------------------------
    float Right_x = 76.5f;
    float Left_x = 74.23f;
    
    // Start is called before the first frame update
    void Start()
    {
        /*
        Home_1_x = Home_1.transform.localPosition.x;
        Insert_2_x = Insert_2.transform.localPosition.x;
        Drawing_3_x = Drawing_3.transform.localPosition.x;
        Design_4_x = Design_4.transform.localPosition.x;
        Change_Screen_5_x = Change_Screen_5.transform.localPosition.x;
        Animation_6_x = Animation_6.transform.localPosition.x;
        Slide_Show_7_x = Slide_Show_7.transform.localPosition.x;
        Censorship_8_x = Censorship_8.transform.localPosition.x;
        Display_9_x = Display_9.transform.localPosition.x;
        */
        //------------------------------------
        Home_Buttoon_1_x = Home_Buttoon_1.transform.localPosition.x;
        Sounyu_Button_2_x = Sounyu_Button_2.transform.localPosition.x;
        Byouga_Button_3_x = Byouga_Button_3.transform.localPosition.x;
        Dezain_Button_4_x = Dezain_Button_4.transform.localPosition.x;
        GamenKirikae_Button_5_x = GamenKirikae_Button_5.transform.localPosition.x;
        Animation_Button_6_x = Animation_Button_6.transform.localPosition.x;
        Slide_Show_Button_7_x = Slide_Show_Button_7.transform.localPosition.x;
        Kouetu_Button_8_x = Kouetu_Button_8.transform.localPosition.x;
        Hyouji_Button_9_x = Hyouji_Button_9.transform.localPosition.x;
        //-------------------------------------
        bar_Image_Ysize = bar_Image.transform.localScale.y;
        Home_Text_Xsize = Home_Buttoon_1.transform.localScale.x * 10;
        Sounyu_Text_Xsize = Sounyu_Button_2.transform.localScale.x * 10;
        Byouga_Text_Xsize = Byouga_Button_3.transform.localScale.x * 10;
        Dezain_Text_Xsize = Dezain_Button_4.transform.localScale.x * 10;
        Gamen_Kirikae_Text_Xsize = GamenKirikae_Button_5.transform.localScale.x * 10;
        Animation_Text_Xsize = Animation_Button_6.transform.localScale.x * 10;
        Slide_Show_Text_Xsize = Slide_Show_Button_7.transform.localScale.x * 10;
        Kouetu_Text_Xsize = Kouetu_Button_8.transform.localScale.x * 10;
        Hyouji_Text_Xsize = Hyouji_Button_9.transform.localScale.x * 10;
        //-------------------------------------
        bar_Image_y = bar_Image.transform.localPosition.y;
        bar_Image_z = bar_Image.transform.localPosition.z;
        //-------------------------------------
        Home_1.SetActive(true);
        Insert_2.SetActive(false);
        Drawing_3.SetActive(false);
        Design_4.SetActive(false);
        Change_Screen_5.SetActive(false);
        Animation_6.SetActive(false);
        Slide_Show_7.SetActive(false);
        Censorship_8.SetActive(false);
        Display_9.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Home_vec = Home_1.transform.localPosition;
        Insert_vec = Insert_2.transform.localPosition;
        Drawing_vec = Drawing_3.transform.localPosition;
        Design_vec = Design_4.transform.localPosition;
        Change_Screen_vec = Change_Screen_5.transform.localPosition;
        Animation_vec = Animation_6.transform.localPosition;
        Slide_Show_vec = Slide_Show_7.transform.localPosition;
        Censorship_vec = Censorship_8.transform.localPosition;
        Display_vec = Display_9.transform.localPosition;
        switch(Button_num){
            case 1:
            to_Left();
            Button_num_befor = Button_num;
            Home_Text.color = Color.yellow;
            Sounyu_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Byouga_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Dezain_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Gamen_Kirikae_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Animation_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Slide_Show_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Kouetu_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Hyouji_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            bar_Image.transform.DOLocalMove(endValue: new Vector3(Home_Buttoon_1_x,bar_Image_y,bar_Image_z),duration: 0.5f);
            bar_Image.transform.DOScale(endValue: new Vector2(Home_Text_Xsize,bar_Image_Ysize),duration: 0.5f);
            break;

            case 2:
            if(Button_num < Button_num_befor){
                to_Left();
                Button_num_befor = Button_num;
            }
            if(Button_num > Button_num_befor){
                to_Right();
                Button_num_befor = Button_num;
            }
            Home_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Sounyu_Text.color = Color.yellow;
            Byouga_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Dezain_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Gamen_Kirikae_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Animation_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Slide_Show_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Kouetu_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Hyouji_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            bar_Image.transform.DOLocalMove(endValue: new Vector3(Sounyu_Button_2_x,bar_Image_y,bar_Image_z),duration: 0.5f);
            bar_Image.transform.DOScale(endValue: new Vector2(Sounyu_Text_Xsize,bar_Image_Ysize),duration: 0.5f);
            break;

            case 3:
            if(Button_num < Button_num_befor){
                to_Left();
                Button_num_befor = Button_num;
            }
            if(Button_num > Button_num_befor){
                to_Right();
                Button_num_befor = Button_num;
            }
            Home_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Sounyu_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Byouga_Text.color = Color.yellow;
            Dezain_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Gamen_Kirikae_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Animation_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Slide_Show_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Kouetu_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Hyouji_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            bar_Image.transform.DOLocalMove(endValue: new Vector3(Byouga_Button_3_x,bar_Image_y,bar_Image_z),duration: 0.5f);
            bar_Image.transform.DOScale(endValue: new Vector2(Byouga_Text_Xsize,bar_Image_Ysize),duration: 0.5f);
            break;

            case 4:
            if(Button_num < Button_num_befor){
                to_Left();
                Button_num_befor = Button_num;
            }
            if(Button_num > Button_num_befor){
                to_Right();
                Button_num_befor = Button_num;
            }
            Home_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Sounyu_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Byouga_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Dezain_Text.color = Color.yellow;
            Gamen_Kirikae_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Animation_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Slide_Show_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Kouetu_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Hyouji_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            bar_Image.transform.DOLocalMove(endValue: new Vector3(Dezain_Button_4_x,bar_Image_y,bar_Image_z),duration: 0.5f);
            bar_Image.transform.DOScale(endValue: new Vector2(Dezain_Text_Xsize,bar_Image_Ysize),duration: 0.5f);
            break;

            case 5:
            if(Button_num < Button_num_befor){
                to_Left();
                Button_num_befor = Button_num;
            }
            if(Button_num > Button_num_befor){
                to_Right();
                Button_num_befor = Button_num;
            }
            Home_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Sounyu_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Byouga_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Dezain_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Gamen_Kirikae_Text.color = Color.yellow;
            Animation_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Slide_Show_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Kouetu_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Hyouji_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            bar_Image.transform.DOLocalMove(endValue: new Vector3(GamenKirikae_Button_5_x,bar_Image_y,bar_Image_z),duration: 0.5f);
            bar_Image.transform.DOScale(endValue: new Vector2(Gamen_Kirikae_Text_Xsize,bar_Image_Ysize),duration: 0.5f);
            break;

            case 6:
            if(Button_num < Button_num_befor){
                to_Left();
                Button_num_befor = Button_num;
            }
            if(Button_num > Button_num_befor){
                to_Right();
                Button_num_befor = Button_num;
            }
            Home_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Sounyu_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Byouga_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Dezain_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Gamen_Kirikae_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Animation_Text.color = Color.yellow;
            Slide_Show_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Kouetu_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Hyouji_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            bar_Image.transform.DOLocalMove(endValue: new Vector3(Animation_Button_6_x,bar_Image_y,bar_Image_z),duration: 0.5f);
            bar_Image.transform.DOScale(endValue: new Vector2(Animation_Text_Xsize,bar_Image_Ysize),duration: 0.5f);
            break;

            case 7:
            if(Button_num < Button_num_befor){
                to_Left();
                Button_num_befor = Button_num;
            }
            if(Button_num > Button_num_befor){
                to_Right();
                Button_num_befor = Button_num;
            }
            Home_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Sounyu_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Byouga_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Dezain_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Gamen_Kirikae_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Animation_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Slide_Show_Text.color = Color.yellow;
            Kouetu_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Hyouji_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            bar_Image.transform.DOLocalMove(endValue: new Vector3(Slide_Show_Button_7_x,bar_Image_y,bar_Image_z),duration: 0.5f);
            bar_Image.transform.DOScale(endValue: new Vector2(Slide_Show_Text_Xsize,bar_Image_Ysize),duration: 0.5f);
            break;

            case 8:
            if(Button_num < Button_num_befor){
                to_Left();
                Button_num_befor = Button_num;
            }
            if(Button_num > Button_num_befor){
                to_Right();
                Button_num_befor = Button_num;
            }
            Home_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Sounyu_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Byouga_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Dezain_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Gamen_Kirikae_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Animation_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Slide_Show_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Kouetu_Text.color = Color.yellow;
            Hyouji_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            bar_Image.transform.DOLocalMove(endValue: new Vector3(Kouetu_Button_8_x,bar_Image_y,bar_Image_z),duration: 0.5f);
            bar_Image.transform.DOScale(endValue: new Vector2(Kouetu_Text_Xsize,bar_Image_Ysize),duration: 0.5f);
            break;

            case 9:
            if(Button_num < Button_num_befor){
                to_Left();
                Button_num_befor = Button_num;
            }
            if(Button_num > Button_num_befor){
                to_Right();
                Button_num_befor = Button_num;
            }
            Home_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Sounyu_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Byouga_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Dezain_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Gamen_Kirikae_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Animation_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Slide_Show_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Kouetu_Text.color = new Color(0/255f, 179f/255f, 255f/255f);
            Hyouji_Text.color = Color.yellow;
            bar_Image.transform.DOLocalMove(endValue: new Vector3(Hyouji_Button_9_x,bar_Image_y,bar_Image_z),duration: 0.5f);
            bar_Image.transform.DOScale(endValue: new Vector2(Hyouji_Text_Xsize,bar_Image_Ysize),duration: 0.5f);
            break;
        }
        
    }

    public void Home(){
        Button_num = 1;
        Home_1.SetActive(true);
        Insert_2.SetActive(false);
        Drawing_3.SetActive(false);
        Design_4.SetActive(false);
        Change_Screen_5.SetActive(false);
        Animation_6.SetActive(false);
        Slide_Show_7.SetActive(false);
        Censorship_8.SetActive(false);
        Display_9.SetActive(false);
    }

    public void Insert(){
        Button_num = 2;
        Home_1.SetActive(false);
        Insert_2.SetActive(true);
        Drawing_3.SetActive(false);
        Design_4.SetActive(false);
        Change_Screen_5.SetActive(false);
        Animation_6.SetActive(false);
        Slide_Show_7.SetActive(false);
        Censorship_8.SetActive(false);
        Display_9.SetActive(false);
    }

    public void Drawing(){
        Button_num = 3;
        Home_1.SetActive(false);
        Insert_2.SetActive(false);
        Drawing_3.SetActive(true);
        Design_4.SetActive(false);
        Change_Screen_5.SetActive(false);
        Animation_6.SetActive(false);
        Slide_Show_7.SetActive(false);
        Censorship_8.SetActive(false);
        Display_9.SetActive(false);
    }

    public void Design(){
        Button_num = 4;
        Home_1.SetActive(false);
        Insert_2.SetActive(false);
        Drawing_3.SetActive(false);
        Design_4.SetActive(true);
        Change_Screen_5.SetActive(false);
        Animation_6.SetActive(false);
        Slide_Show_7.SetActive(false);
        Censorship_8.SetActive(false);
        Display_9.SetActive(false);
    }

    public void Change_Screen(){
        Button_num = 5;
        Home_1.SetActive(false);
        Insert_2.SetActive(false);
        Drawing_3.SetActive(false);
        Design_4.SetActive(false);
        Change_Screen_5.SetActive(true);
        Animation_6.SetActive(false);
        Slide_Show_7.SetActive(false);
        Censorship_8.SetActive(false);
        Display_9.SetActive(false);
    }

    public void Animation(){
        Button_num = 6;
        Home_1.SetActive(false);
        Insert_2.SetActive(false);
        Drawing_3.SetActive(false);
        Design_4.SetActive(false);
        Change_Screen_5.SetActive(false);
        Animation_6.SetActive(true);
        Slide_Show_7.SetActive(false);
        Censorship_8.SetActive(false);
        Display_9.SetActive(false);
    }

    public void Slide_Show(){
        Button_num = 7;
        Home_1.SetActive(false);
        Insert_2.SetActive(false);
        Drawing_3.SetActive(false);
        Design_4.SetActive(false);
        Change_Screen_5.SetActive(false);
        Animation_6.SetActive(false);
        Slide_Show_7.SetActive(true);
        Censorship_8.SetActive(false);
        Display_9.SetActive(false);
    }

    public void Censorship(){
        Button_num = 8;
        Home_1.SetActive(false);
        Insert_2.SetActive(false);
        Drawing_3.SetActive(false);
        Design_4.SetActive(false);
        Change_Screen_5.SetActive(false);
        Animation_6.SetActive(false);
        Slide_Show_7.SetActive(false);
        Censorship_8.SetActive(true);
        Display_9.SetActive(false);
    }

    public void Display(){
        Button_num = 9;
        Home_1.SetActive(false);
        Insert_2.SetActive(false);
        Drawing_3.SetActive(false);
        Design_4.SetActive(false);
        Change_Screen_5.SetActive(false);
        Animation_6.SetActive(false);
        Slide_Show_7.SetActive(false);
        Censorship_8.SetActive(false);
        Display_9.SetActive(true);
    }
    
    private void to_Left(){
        if(Button_num == 1){
            Home_vec.x = Right_x;
            Home_1.transform.localPosition = Home_vec;
            Home_1.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
        if(Button_num == 2){
            Insert_vec.x = Right_x;
            Insert_2.transform.localPosition = Insert_vec;
            Insert_2.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
        if(Button_num == 3){
            Drawing_vec.x = Right_x;
            Drawing_3.transform.localPosition = Drawing_vec;
            Drawing_3.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
        if(Button_num == 4){
            Design_vec.x = Right_x;
            Design_4.transform.localPosition = Design_vec;
            Design_4.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
        if(Button_num == 5){
            Change_Screen_vec.x = Right_x;
            Change_Screen_5.transform.localPosition = Change_Screen_vec;
            Change_Screen_5.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
        if(Button_num == 6){
            Animation_vec.x = Right_x;
            Animation_6.transform.localPosition = Animation_vec;
            Animation_6.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
        if(Button_num == 7){
            Slide_Show_vec.x = Right_x;
            Slide_Show_7.transform.localPosition = Slide_Show_vec;
            Slide_Show_7.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
        if(Button_num == 8){
            Censorship_vec.x = Right_x;
            Censorship_8.transform.localPosition = Censorship_vec;
            Censorship_8.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
        if(Button_num == 9){
            Display_vec.x = Right_x;
            Display_9.transform.localPosition = Display_vec;
            Display_9.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
        
    }
    private void to_Right(){
        if(Button_num == 1){
            Home_vec.x = Left_x;
            Home_1.transform.localPosition = Home_vec;
            Home_1.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
        if(Button_num == 2){
            Insert_vec.x = Left_x;
            Insert_2.transform.localPosition = Insert_vec;
            Insert_2.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
        if(Button_num == 3){
            Drawing_vec.x = Left_x;
            Drawing_3.transform.localPosition = Drawing_vec;
            Drawing_3.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
        if(Button_num == 4){
            Design_vec.x = Left_x;
            Design_4.transform.localPosition = Design_vec;
            Design_4.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
        if(Button_num == 5){
            Change_Screen_vec.x = Left_x;
            Change_Screen_5.transform.localPosition = Change_Screen_vec;
            Change_Screen_5.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
        if(Button_num == 6){
            Animation_vec.x = Left_x;
            Animation_6.transform.localPosition = Animation_vec;
            Animation_6.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
        if(Button_num == 7){
            Slide_Show_vec.x = Left_x;
            Slide_Show_7.transform.localPosition = Slide_Show_vec;
            Slide_Show_7.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
        if(Button_num == 8){
            Censorship_vec.x = Left_x;
            Censorship_8.transform.localPosition = Censorship_vec;
            Censorship_8.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
        if(Button_num == 9){
            Display_vec.x = Left_x;
            Display_9.transform.localPosition = Display_vec;
            Display_9.transform.DOLocalMove(endValue: new Vector3(75.122f,-151.3f,0),duration: 0.2f);
        }
    }

    public void NextScene(){
        SceneManager.LoadScene("InsTech OP");
    }
}
