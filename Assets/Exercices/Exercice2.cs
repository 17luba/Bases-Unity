using UnityEngine;

public class Exercice2 : MonoBehaviour
{
    /* 
     * NE PAS SUPPRIMER L'ÉNONCÉ DE L'EXERCICE
     * Exercice 2 : Couleur aléatoire
     * Lorsque ce script est attaché à un objet, l'objet doit changer de couleur aléatoirement chaque seconde.
     */

    // Code à compléter (ne rien modifier avant cette ligne)

    void Start()
    {
        InvokeRepeating("ChangeColor", 0, 1);
    }
    private void ChangeColor()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = randomColor;
    }

    // Fin du code à compléter (ne rien modifier après cette ligne)
}
