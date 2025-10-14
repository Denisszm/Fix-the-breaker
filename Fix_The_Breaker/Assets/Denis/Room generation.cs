using NUnit.Framework;
using UnityEngine;
public class NewEmptyCSharpScript
{
    class Roomgeneration : MonoBehaviour
    {
         
    }
    class Rooms
    {
        [SerializeField] private Vector2 pos = new Vector2();

        public enum Type
        {
            Breaker,
            Breakroom,
            Office,
            Corridor,
            Factory
        }
    }

}
