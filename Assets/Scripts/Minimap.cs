using UnityEngine;

public class Minimap : MonoBehaviour
{
    public Transform player;
    void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(0f, player.eulerAngles.y * -1f, 0f);
    }
}
