using UnityEngine;

public class DoorLookInteraction : MonoBehaviour
{
    public float interactionRange = 5f;

    private Door currentDoor;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactionRange))
        {
            Door door = hit.collider.GetComponent<Door>();

            if (door != null)
            {
                currentDoor = door;
                door.SetLooking(true);
            }
            else
            {
                if (currentDoor != null)
                {
                    currentDoor.SetLooking(false);
                    currentDoor = null;
                }
            }
        }
        else
        {
            if (currentDoor != null)
            {
                currentDoor.SetLooking(false);
                currentDoor = null;
            }
        }
    }
}