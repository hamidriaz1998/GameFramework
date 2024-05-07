using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework{
    public class CollisionDetection
    {
        private GameObjectType Type1;
        private GameObjectType Type2;
        private CollisionAction Action;
        public CollisionDetection(GameObjectType type1, GameObjectType type2, CollisionAction action)
        {
            Type1 = type1;
            Type2 = type2;
            Action = action;
        }
        public void CheckCollision(List<GameObject> gameObjects)
        {
            var type1Objects = gameObjects.Where(go => go.Type == Type1);
            var type2Objects = gameObjects.Where(go => go.Type == Type2);
            foreach (var go1 in type1Objects)
            {
                foreach (var go2 in type2Objects)
                {
                    if (go1.Pb.Bounds.IntersectsWith(go2.Pb.Bounds))
                    // TODO: Implement collision action
                    {
                        if (Action == CollisionAction.IncreaseHealth)
                        {
                            

                        }   
                    }
                }
            }
        }
    }
}
