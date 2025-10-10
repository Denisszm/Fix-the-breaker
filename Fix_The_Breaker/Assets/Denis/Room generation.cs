using NUnit.Framework;
using UnityEngine;
public class NewEmptyCSharpScript
{
    class Roomgeneration : MonoBehaviour
    {
         
    }
    class Rooms
    {
        [SerializeField] private Vector2 _pos = new Vector2();

        public enum type
        {
            Breaker,
            Breakroom,
            Office,
            Corridor,
            Factory
        }
    }

}
