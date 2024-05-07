using GameFramework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework{
    internal class CollisionDetection
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
            foreach (GameObject go1 in type1Objects)
            {
                foreach (GameObject go2 in type2Objects)
                {
                    if (go1 == go2)
                    {
                        // To avoid checking collision with self
                        continue;
                    }
                    if (go1.Pb.Bounds.IntersectsWith(go2.Pb.Bounds))
                    // TODO: Implement collision action
                    {
                        if (Action == CollisionAction.IncreaseHealth)
                        {
                            Character c1 = (Character)go1;
                            Character c2 = (Character)go2;
                            c1.IncreaseHealth(1);
                            c2.IncreaseHealth(1);
                        }   
                        else if (Action == CollisionAction.DecreaseHealth)
                        {
                            Character c1 = (Character)go1;
                            Character c2 = (Character)go2;
                            c1.DecreaseHealth(1);
                            c2.DecreaseHealth(1);
                        }
                    }
                }
            }
        }
    }
}
