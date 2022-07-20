using UnityEngine;

public class Minimap : MonoBehaviour
{
    [Header("Rotation du modèle 3D")]
    [Tooltip("La valeur de rotation en axe Y est égale à la caméra principale")]
    public Transform player;
    void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(0f, player.eulerAngles.y * -1f, 0f);
    }
}
