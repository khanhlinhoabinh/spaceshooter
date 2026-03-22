using UnityEngine;

public class FlyPathAgent : MonoBehaviour
{
    public FlyPath flyPath;
    public float flySpeed = 2f;

    private int nextIndex = 1;

    void Start()
    {
        if (flyPath == null || flyPath.waypoints.Length == 0)
        {
            Debug.LogError("FlyPath missing!");
            return;
        }

        transform.position = flyPath[0];
    }

    void Update()
    {
        if (flyPath == null || flyPath.waypoints.Length == 0)
            return;

        if (nextIndex >= flyPath.waypoints.Length)
        {
            // Đừng destroy để dễ debug
            return;
        }

        transform.position = Vector3.MoveTowards(
            transform.position,
            flyPath[nextIndex],
            flySpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, flyPath[nextIndex]) < 0.01f)
        {
            nextIndex++;
        }
    }
}