namespace Exam_Kata;

public interface ICombat
{
    void Attack(ICombat target);
    void TakeDamage(int damage);
}