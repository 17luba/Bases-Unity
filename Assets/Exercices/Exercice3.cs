using UnityEngine;

public class Exercice3 : MonoBehaviour
{
    /* 
     * NE PAS SUPPRIMER L'ÉNONCÉ DE L'EXERCICE
     * Exercice 3 : Transformation
     * Le script doit être attaché à un objet. Lorsqu'on appuie sur Espace, l'objet doit se transformer.
     * La transformation est aléatoire. Il faut utiliser les primitives (cube, sphere, plane, cylindre, Capsule).
     * Il ne doit y avoir que 1 GameObjet sur la scène et cet objet doit être transformé.
     */

    // Code à compléter (ne rien modifier avant cette ligne)

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TransformObject();

        }
    }
    void TransformObject()
    {
        PrimitiveType[] types = new PrimitiveType[]
        {
        PrimitiveType.Cube,
        PrimitiveType.Sphere,
        PrimitiveType.Cylinder,
        PrimitiveType.Capsule,
        };

        int randomIndex = Random.Range(0, types.Length);
        PrimitiveType selectedType = types[randomIndex];
        MeshFilter meshFilter = gameObject.GetComponent<MeshFilter>();

        if (meshFilter != null)
        {
            //GameObject primitive = GameObject.CreatePrimitive(types[randomIndex]);
            //meshFilter.mesh = primitive.GetComponent<MeshFilter>().mesh;

            string meshName = "";
            switch (selectedType)
            {
                case PrimitiveType.Cube: meshName = "Cube.fbx"; break;
                case PrimitiveType.Sphere: meshName = "Sphere.fbx"; break;
                case PrimitiveType.Cylinder: meshName = "Cylinder.fbx"; break;
                case PrimitiveType.Capsule: meshName = "Capsule.fbx"; break;
            }
            Mesh newMesh = Resources.GetBuiltinResource<Mesh>(meshName);

            if (newMesh != null ) 
            {
                meshFilter.mesh = newMesh;
            }
            else
            {
                Debug.LogError("Mesh non trouvé pour " + selectedType);
            }
        }
       
    }

    // Fin du code à compléter (ne rien modifier après cette ligne)
}
