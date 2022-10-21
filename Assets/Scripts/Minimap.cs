using UnityEngine;

public class Minimap : MonoBehaviour
{
    [Header("Rotation du modèle 3D")]
    [Tooltip("La valeur de rotation en axe Y est égale à la caméra principale")]
    public Transform player;

    [Header("Agrandir la carte")]
    public GameObject grow;
    [Header("Reduire la carte")]
    public GameObject reduce;
    void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(0f, player.eulerAngles.y * -1f, 0f);
    }

    public void Grow()
    {
        reduce.SetActive(false);
        grow.SetActive(true);
    }
    public void Reduce()
    {
        reduce.SetActive(true);
        grow.SetActive(false);
    }
}
