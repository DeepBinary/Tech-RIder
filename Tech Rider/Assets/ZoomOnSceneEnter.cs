using UnityEngine;

public class ZoomOnSceneEnter : MonoBehaviour
{
    public float animationduration;
    private void OnEnable()
    {
        transform.LeanScale(new Vector3(10, 10, 1), animationduration + 5);
        transform.LeanScale(new Vector3(1, 1, 1), animationduration + 5).setEaseOutExpo();             
    }
}
