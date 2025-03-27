using UnityEngine;

public class Exercice4 : MonoBehaviour
{
    /* 
     * NE PAS SUPPRIMER L'ÉNONCÉ DE L'EXERCICE
     * Exercice 4 : Déplacement
     * Une fois le script attaché à un objet, l'objet doit pouvoir être déplacé avec les flèches du clavier et Espace.
     * Les flèches du clavier permettent de déplacer l'objet horizontalement et verticalement.
     * La touche Espace permet de sauter/s'élever en l'air.
     * Il n'est pas nécessaire de gérer la gravité, les collisions etc.
     */

    // Code à compléter (ne rien modifier avant cette ligne)

    public float moveSpeed = 5f;
    public float jumpHeight = 5f;

    void Update()
    {
        // Récupérer les entrées des touches fléchées
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // Déplacer l'objet horizontalement et verticalement
        transform.Translate(moveX, moveY, 0);

        // Détecter la touche Espace pour sauter
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0, jumpHeight, 0);
        }
    }

    // Fin du code à compléter (ne rien modifier après cette ligne)
}
