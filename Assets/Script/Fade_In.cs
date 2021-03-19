using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Fade_In : MonoBehaviour
{
  [SerializeField]
  Fade fade = null;

  [SerializeField]
  RectTransform rectTran;

  public float zoom_SpeedTime = 2.0f;
  public float alpha_plus = 0.1f, alpha_minus = 0.005f;
  int alpha_f = 0;
  public GameObject MwU;
  float alpha;
  int loop_cnt = 0;
    // Start is called before the first frame update
    void Start()
    {
      MwU.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, alpha);
    }

    // Update is called once per frame
    void Update()
    {
      if(loop_cnt == 0){
        if(alpha >= 0.0f && alpha_f == 0){
          alpha += alpha_plus;
        }
        if(alpha >= 1.0f){
          alpha_f = 1;
        }
        if(alpha_f == 1){
          alpha -= alpha_minus;
        }
        if(alpha < 0.0f && alpha_f == 1){
          loop_cnt = 1;
          onComplete();
        }
        rectTran.DOScale(endValue: new Vector3(10.83974f,10.83974f,10.83974f), duration: 2.0f);
      }
      MwU.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, alpha);
    }
    
    public void onComplete()
    {
        SceneManager.LoadScene("Main");
    }
}
