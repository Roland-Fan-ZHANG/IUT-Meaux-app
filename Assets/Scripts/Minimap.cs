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

    [Header("List current arrows")]
    public GameObject[] arrows;

/*    public void Start()
    {
        arrows = GameObject.FindGameObjectsWithTag("Arrow");
        for (int i = 0; i < arrows.Length; i++)
        {
            arrows[i].SetActive(false);
        }
    }*/
    void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(0f, player.eulerAngles.y * -1f, 0f);
    }

    public void Grow()
    {
        arrows = GameObject.FindGameObjectsWithTag("Arrow");        //check current arrows
        for (int i = 0; i < arrows.Length; i++)
        {
            arrows[i].SetActive(false);     //Disable current arrows
        }
        reduce.SetActive(false);
        grow.SetActive(true);
    }
    public void Reduce()
    {
        for (int i = 0; i < arrows.Length; i++)
        {
            arrows[i].SetActive(true);      //Enable current arrows
        }
        reduce.SetActive(true);
        grow.SetActive(false);
    }
}
