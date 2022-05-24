namespace RPG.Dio.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public override string ToString()
        {
            return $"[Name={Name}, Level={Level}, HeroType={HeroType}]";
        }
        public abstract string Attack();
        public string Attack(int bonus)
        {
            if (bonus > 6)
                return Attack() + $". O ataque foi super efetivo, e recebeu um bônus de ataque de {bonus}";
            else
                return Attack() + $". O ataque foi pouco efetivo, e recebeu um bônus de ataque de {bonus}";
        }
    }
}
