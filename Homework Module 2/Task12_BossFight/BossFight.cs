using System.Text;
namespace Homework_Module_2.Task12_BossFight;

public class BossFight
{
    public void Run()
    {
        Random random = new();

        const string REG_DAMAGE = "1";
        const string FIREBALL = "2";
        const string EXPLOSION = "3";
        const string HEALING = "4";
        
        int bossLife = 500;
        int bossDamage;
        int bossMinDamage = 20;
        int bossMaxDamage = 40;
        
        int heroLife = 400;
        int maxHeroLife = 400;
        int heroMana = 100;
        int maxHeroMana = 100;
        int heroRegularDamage;
        int heroMinDamage = 15;
        int heroMaxDamage = 35;
        int heroFireballDamage = 20;
        int heroExplosionDamage = 70;
        int fireballCoast = 30;
        int healingQuantity = 5;
        int healingLifePoints = 20;
        int healingManaPoints = 10;
        
        bool wasFireballUsed = false;
        
        StringBuilder userInput = new ();

        while (bossLife > 0 && heroLife > 0)
        {
            Console.Clear();
            
            Console.WriteLine($"HERO: Жизни:{heroLife} | Мана:{heroMana}\nBOSS: Жизни:{bossLife}");
            Console.WriteLine("Ваш ход! Доступные умения:");
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
                    heroRegularDamage = random.Next(heroMinDamage, heroMaxDamage);
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
                bossDamage = random.Next(bossMinDamage, bossMaxDamage);
                heroLife -= bossDamage;
                Console.WriteLine($"BOSS нанес вам {bossDamage} урона!");
                if (heroLife <= 0)
                {
                    Console.WriteLine("ВЫ ПРОИГРАЛИ!");
                }
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