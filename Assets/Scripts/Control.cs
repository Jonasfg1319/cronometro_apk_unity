using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    private bool comecar = false;
    public Text minutosText, segundosText,horasText;
    float second;
    private int minutos = 0, segundos = 0,horas = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        segundosText.text = segundos.ToString();
        minutosText.text = minutos.ToString();
        horasText.text = horas.ToString();

        if (Input.GetButtonDown("Jump"))
        {
         
            comecar = true;
        }
        else if (Input.GetKeyDown(KeyCode.P))
            comecar = false;

        if (comecar)
        {
            second += Time.deltaTime;
            segundos = (int)second;
            

            if (segundos == 60)
                minuto();
            if (minutos == 60)
                hora();
        }
    }

    void minuto()
    {

            second = 0;
            minutos ++;
           
        
    }

    void hora() {

        minutos = 0;
        horas++;
    }

   public void Comecar() {

        comecar = true;
    }

    public void Parar()
    {
        comecar = false;
    }

   public void Reiniciar() {

        segundos = 0;
        second = 0;
        minutos = 0;
        horas = 0;
        comecar = false;

    }
}
