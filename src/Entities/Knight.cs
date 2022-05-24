namespace RPG.Dio.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
        }

        public override string Attack()
        {
            return Name + " atacou com sua espada";
        }
    }
}
