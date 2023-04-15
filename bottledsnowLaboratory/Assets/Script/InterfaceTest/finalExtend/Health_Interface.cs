public interface IHealth
{
    int Health { get; set; }
    int Defense { get; set; }

    void TakeDamage(int Damage);
}
