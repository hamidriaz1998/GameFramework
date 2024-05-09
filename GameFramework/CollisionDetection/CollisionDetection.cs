using GameFramework.Core;
using System.Collections.Generic;
using System.Linq;

namespace GameFramework
{
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
        private bool IsCharacter(GameObjectType type)
        {
            return type == GameObjectType.Player || type == GameObjectType.Enemy;
        }
        private bool IsBullet(GameObjectType type)
        {
            return type == GameObjectType.PlayerBullet || type == GameObjectType.EnemyBullet;
        }
        private void IncreaseHealth(GameObject go)
        {
            if (IsCharacter(go.Type))
            {
                var c = (Character)go;
                c.IncreaseHealth(3);
            }
            else if (IsBullet(go.Type))
            {
                Game.GetInstance().RemoveGameObject(go);
            }
        }
        private void DecreaseHealth(GameObject go)
        {
            if (IsCharacter(go.Type))
            {
                var c = (Character)go;
                c.DecreaseHealth(3);
            }
            else if (IsBullet(go.Type))
            {
                Game.GetInstance().RemoveGameObject(go);
            }
        }
        public void CheckCollision(List<GameObject> gameObjects)
        {
            var type1Objects = gameObjects.Where(go => go.Type == Type1).ToArray();
            var type2Objects = gameObjects.Where(go => go.Type == Type2).ToArray();
            for (int i = 0; i < type1Objects.Count(); i++)
            {
                for (int j = 0; j < type2Objects.Count(); j++)
                {
                    var go1 = type1Objects[i];
                    var go2 = type2Objects[j];
                    if (go1 == go2)
                    {
                        // To avoid checking collision with self
                        continue;
                    }
                    if (go1.Pb.Bounds.IntersectsWith(go2.Pb.Bounds))
                    {
                        if (Action == CollisionAction.IncreaseScore)
                        {
                            Game.GetInstance().IncreaseScore(5);
                        }
                        else if (Action == CollisionAction.DecreaseScore)
                        {
                            Game.GetInstance().DecreaseScore(5);
                        }
                        else if (Action == CollisionAction.IncreaseHealth)
                        {
                            IncreaseHealth(go1);
                            IncreaseHealth(go2);
                        }
                        else if (Action == CollisionAction.DecreaseHealth)
                        {
                            DecreaseHealth(go1);
                            DecreaseHealth(go2);
                        }
                    }
                }
            }
        }
    }
}
