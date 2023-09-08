using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int puntuacionJugadorIzq = 0;
    public int puntuacionJugadorDer = 0;

    // jugador = 0 -> jugador izquierda
    // jugador = 1 -> jugador derecha
    public void Goal(int jugador)
    {
        if (jugador == 0)
        {
            puntuacionJugadorIzq = puntuacionJugadorIzq + 1;
        }else 
        {
            puntuacionJugadorDer++;
        }
    }
}
