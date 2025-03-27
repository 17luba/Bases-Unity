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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }    

    // Fin du code à compléter (ne rien modifier après cette ligne)
}
