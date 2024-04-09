using UnityEngine;

public class PlateformeSpawn : MonoBehaviour
{
    public GameObject plateformePrefab; // Le prefab de la plateforme à instancier
    public LayerMask groundLayer; // Le calque de la plateforme
    public float distanceToSpawn = 1f; // Distance minimale pour instancier une plateforme en dessous du personnage

    void Update()
    {
        // Vérifie si le personnage n'est pas au-dessus d'une plateforme
        if (!Physics.Raycast(transform.position, Vector3.down, distanceToSpawn, groundLayer))
        {
            // Instancie une nouvelle plateforme en dessous du personnage
            Instantiate(plateformePrefab, transform.position - Vector3.up * distanceToSpawn, Quaternion.identity);
        }
    }
}