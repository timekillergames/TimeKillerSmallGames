using UnityEngine;
using System.Collections;

public class PlayerFruitMover : MonoBehaviour
{
    public GameObject PlayerFruit;
    public float PlayerSpeed;

    public Material[] FruitsMaterials;

    private Vector3 MouseClickPosition;
    private RaycastHit hit;

    void Start()
    {
        ChangeFruitMaterial();
        hit = new RaycastHit();
    }

    void Update()
    {
    }

    void OnMouseDown()
    {

    }

    void OnMouseUp()
    {
        SetMousePosition();
        AddVelocityToPlayerFruit();
        ChangeFruitMaterial();
    }

    private void SetMousePosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 10000.0f))
        {
            Vector3 newpos = new Vector3(hit.point.x, 0.5f, hit.point.z);
            MouseClickPosition = newpos;
        }
    }

    private void AddVelocityToPlayerFruit()
    {
        PlayerFruit.rigidbody.velocity = (MouseClickPosition - PlayerFruit.rigidbody.transform.position) * PlayerSpeed;
    }

    private void ChangeFruitMaterial()
    {
        if (FruitsMaterials != null && PlayerFruit != null)
        {
            int materialId = UnityEngine.Random.Range(0, FruitsMaterials.Length);
            PlayerFruit.gameObject.renderer.material = FruitsMaterials[materialId];
        }
    }
}