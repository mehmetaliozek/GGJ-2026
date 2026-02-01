using UnityEngine;

public class Visitor : MonoBehaviour
{
    public VisitorType type;

    public VisitorType GetVisitorType()
    {
        return type;
    }
}
