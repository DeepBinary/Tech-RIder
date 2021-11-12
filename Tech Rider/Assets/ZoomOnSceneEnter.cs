using UnityEngine;

public class ZoomOnSceneEnter : MonoBehaviour
{
    public float animationduration;
    private void OnEnable()
    {
        transform.LeanScale(new Vector3(4, 4, 1), animationduration);
        transform.LeanScale(new Vector3(1, 1, 1), animationduration).setEaseOutExpo();
    }
}
