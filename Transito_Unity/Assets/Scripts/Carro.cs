using UnityEngine;

public class Carro : MonoBehaviour
{
   

    public float speed = 4f;
    public enum State
    {
        parado = 0,
        movendo = 1,
    }

    State estado = State.parado;
    public void Mudanca()
    {
        switch (estado)
        {
            case State.parado:
                estado = State.movendo;
                break;
            case State.movendo:
                estado = State.parado;
                break;
        }
    }
    void Update()
    {
        Atualiza();
    }

    public void Atualiza()
    {
        switch (estado)
        {
            case State.parado:
                break;
            case State.movendo:
                transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
                break;
        }
    }

}
