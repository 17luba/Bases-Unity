using UnityEngine;

public class Exercice5 : MonoBehaviour
{
    /* 
     * NE PAS SUPPRIMER L'ÉNONCÉ DE L'EXERCICE
     * Exercice 5 : Trou noir
     * Le script doit être attaché à un objet (le trou noir / un cube / une sphère). 
     * Il faut placer d'autres objets sur la scène.
     * Lorsqu'un autre objetse trouve à moins de 3 unités de l'objet auquel le script est attaché (trou noir), il est aspiré/Attiré vers l'objet.
     * L'objet aspiré doit être détruit lors de la collision.
     */

    // Code à compléter (ne rien modifier avant cette ligne)

    public float attractionForce = 5f;
    public float destructionDistance = 3f;

    void Update()
    {
        // Detect and attract objects
        DetectAndAttractObjects();
    }

    void DetectAndAttractObjects()
    {
        // Get all colliders within a sphere of radius 'destructionDistance'
        Collider[] colliders = Physics.OverlapSphere(transform.position, destructionDistance);

        // Iterate through each collider
        foreach (Collider collider in colliders)
        {
            // Check if the collider is not the black hole itself
            if (collider.gameObject != gameObject)
            {
                // Attract the object towards the black hole
                AttractObject(collider.gameObject);
            }
        }
    }

    void AttractObject(GameObject obj)
    {
        // Calculate the direction towards the black hole
        Vector3 direction = transform.position - obj.transform.position;

        // Apply a force towards the black hole
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(direction.normalized * attractionForce * Time.deltaTime);
        }

        // Check if the object is within the destruction distance
        if (direction.magnitude <= destructionDistance)
        {
            // Destroy the object
            Destroy(obj);
        }
    }
    // Fin du code à compléter (ne rien modifier après cette ligne)
}
