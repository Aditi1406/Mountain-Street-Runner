using UnityEngine;

public class CameraFolder : MonoBehaviour
{
    public Transform player;
    Vector3 offset;

    // Start is called before the first frame update
    public void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    public void Update()
    {
        Vector3 targetpos = player.position + offset;
        targetpos.x = 0;
        transform.position = targetpos;
    }
}
