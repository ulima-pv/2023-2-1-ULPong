using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public int puntuacionJugadorIzq = 0;
    public int puntuacionJugadorDer = 0;

    public TextMeshProUGUI textPuntajeIzq;
    public TextMeshProUGUI textPuntajeDer;

    public event UnityAction OnPauseGame; // evento
    public event UnityAction OnRestartGame; // evento

    // jugador = 0 -> jugador izquierda
    // jugador = 1 -> jugador derecha
    public void Goal(int jugador)
    {
        if (jugador == 0)
        {
            puntuacionJugadorIzq = puntuacionJugadorIzq + 1;
            textPuntajeIzq.text = puntuacionJugadorIzq.ToString();
        }else 
        {
            puntuacionJugadorDer++;
            textPuntajeDer.text = puntuacionJugadorDer.ToString();
        }
        textPuntajeIzq.gameObject.SetActive(true);
        textPuntajeDer.gameObject.SetActive(true);
        OnPauseGame.Invoke();
    }

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Reiniciar el juego
            textPuntajeIzq.gameObject.SetActive(false);
            textPuntajeDer.gameObject.SetActive(false);
            OnRestartGame.Invoke();
        }
    }
}
