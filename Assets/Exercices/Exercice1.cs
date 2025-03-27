using UnityEngine;

public class Exercice1 : MonoBehaviour
{
    /* 
     * NE PAS SUPPRIMER L'ÉNONCÉ DE L'EXERCICE
     * Exercice 1 : Visibilité alternée
     * Placer le script sur un objet (cube, sphere...).
     * Le script doit afficher/masquer l'objet sur lequel il est placé lors de l'appuie sur Espace.
     * Si l'objet est visible, il doit être masqué, et inversement.
     */

    // Code à compléter (ne rien modifier avant cette ligne)

    // Variable pour stocker l'état de visibilité du cube
    private bool isVisible = true;

    // Méthode appelée à chaque frame pour détecter l'appui sur une touche
    void Update()
    {
        // Vérifie si la touche "Espace" est pressée
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Change l'état de visibilité
            isVisible = !isVisible;

            // Active ou désactive le rendu du cube
            GetComponent<Renderer>().enabled = isVisible;
        }
    }   

    // Fin du code à compléter (ne rien modifier après cette ligne)
}
