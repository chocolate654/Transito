using UnityEngine;

public class Sinal : MonoBehaviour
{
    public enum state{
    red ,
    green ,
    yellow
  }
  
  [SerializeField] GameObject obj;
  public state atual = state.red;
  public float greentimer=4f;
  public float yellowtimer=2f;
  public float redtimer=4f;


  float timer=0;
 
    void Update()
    {
        timer-=Time.deltaTime;
        if(timer<=0)
        switch(atual)
        {
          case state.red:
          atual = state.green;
        timer = greentimer;
        break;
        case state.green:
        atual = state.yellow;
        timer = yellowtimer;
        break;
        case state.yellow:
          atual = state.red;
        timer = redtimer;
        break;







        }
      obj.GetComponent<SpriteRenderer>().color = Color.green;
      obj.GetComponent<SpriteRenderer>().color = Color.yellow;
      obj.GetComponent<SpriteRenderer>().color = Color.red;


    }
}
