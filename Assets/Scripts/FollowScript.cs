using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public Transform player;
    public Vector3 offest;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offest;
    }
}
