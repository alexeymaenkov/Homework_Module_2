using System.Globalization;
using System.Text;
namespace Homework_Module_2.Task12_BossFight;

public class BossFight
{
    public void Run()
    {
        /*
        Легенда:
        Вы - герой и у вас есть несколько умений, которые вы можете использовать против Босса. Вы должны уничтожить босса и только после этого будет вам покой.

        Формально:
        Перед вами Босс, у которого есть определенное количество жизней и атака.
        Атака может быть как всегда одной и той же, так и определяться рандомом в начале раунда.
        У Босса обычная атака. Босс должен иметь возможность убить героя.
            У героя есть 4 умения:
        1. Обычная атака
        2. Огненный шар, который тратит ману
        3. Взрыв. Можно вызывать, только если был использован огненный шар. Для повторного применения надо повторно использовать огненный шар.
        4. Лечение. Восстанавливает здоровье и ману, но не больше их максимального значения. Можно использовать ограниченное число раз.
        
            Если пользователь ошибся с вводом команды или не выполнилось условие, то герой пропускает ход и происходит атака Босса
            Программа завершается только после смерти босса или смерти пользователя, а если у вас возможно одновременно убить друг друга,
            то надо сообщить о ничье. */
        
        Random random = new();

        const string REG_DAMAGE = "1";
        const string FIREBALL = "2";
        const string EXPLOSION = "3";
        const string HEALING = "4";
        
        int bossLife = 1000;
        int bossDamage;
        int heroLife = 200;
        int maxHeroLife = 200;
        int heroMana = 100;
        int maxHeroMana = 100;
        int heroRegularDamage;
        int heroFireballDamage = 25;
        int heroExplosionDamage = 75;
        int fireballCoast = 10;
        int healingQuantity = 5;
        int healingLifePoints = 20;
        int healingManaPoints = 10;
        
        bool wasFireballUsed = false;
        
        StringBuilder userInput = new ();

        while (bossLife > 0 && heroLife > 0)
        {
            Console.Clear();
            
            Console.WriteLine($"HERO: Жизни:{heroLife} | Мана:{heroMana}\nBOSS: Жизни:{bossLife}");
            Console.WriteLine($"Ваш ход! Доступные умения:");
            Console.WriteLine($"{REG_DAMAGE} - Обычная атака");
            Console.WriteLine($"{FIREBALL} - Огненный шар: урон = {heroFireballDamage}, (тратит {fireballCoast} едениц маны)");
            Console.WriteLine($"{EXPLOSION} - Взрыв: урон = {heroExplosionDamage}. Можно вызывать, только если был использован огненный шар.");
            Console.WriteLine($"{HEALING} - Лечение. Восстанавливает здоровье на {healingLifePoints}, и ману на {healingManaPoints}. Осталось {healingQuantity} аптечек.");
            
            Console.Write("Введите номер умения: ");
            userInput.Clear();
            userInput.Append(Console.ReadLine());

            switch (userInput.ToString())
            {
                case REG_DAMAGE:
                    wasFireballUsed = false;
                    heroRegularDamage = random.Next(10, 30);
                    bossLife -= heroRegularDamage;
                    Console.WriteLine($"Вы нанесли BOSS {heroRegularDamage} урона!");
                    break;
                
                case FIREBALL:
                    if (heroMana >= fireballCoast)
                    {
                        wasFireballUsed = true;
                        heroMana -= fireballCoast;
                        bossLife -= heroFireballDamage;
                        Console.WriteLine($"Вы нанесли BOSS {heroFireballDamage} урона!");
                    }
                    else
                    {
                        Console.WriteLine("У вас не достаточно маны!");
                    }
                    break;
                
                case EXPLOSION:
                    if (wasFireballUsed)
                    {
                        bossLife -= heroExplosionDamage;
                        Console.WriteLine($"Вы нанесли BOSS {heroExplosionDamage} урона!");
                    }
                    else
                    {
                        Console.WriteLine("Огненный шар не был использован!");
                    }
                    wasFireballUsed = false;
                    break;
                
                case HEALING:
                    if (healingQuantity > 0)
                    {
                        healingQuantity--;
                        heroLife += healingLifePoints;
                        heroMana += healingManaPoints;
                        if (heroLife > maxHeroLife)
                        {
                            heroLife = maxHeroLife;
                        }
                        if (heroMana > maxHeroMana)
                        {
                            heroMana = maxHeroMana;
                        }
                        Console.WriteLine($"Вы излечились: Жизни:{heroLife}, Мана:{heroMana}.");
                    }
                    else
                    {
                        Console.WriteLine("У вас не осталось аптечек!");
                    }
                    wasFireballUsed = false;
                    break;
                
                default:
                    Console.WriteLine("Не верный номер команды!!!");
                    break;
            }

            if (bossLife > 0)
            {
                Console.WriteLine("BOSS атакует!");
                bossDamage = random.Next(20, 50);
                heroLife -= bossDamage;
                Console.WriteLine($"BOSS нанес вам {bossDamage} урона!");
                Console.Write("Нажмите любую клавишу для продолжения: ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("ВЫ ПОБЕДИЛИ!");
            }
        }
    }
}