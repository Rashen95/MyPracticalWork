Console.Clear();
Console.WriteLine("Два друга двигаются навстречу. От первого друга навстречу второму бежит собака и после встречи со вторым другом начинает движение обратно к первому. ");
Console.WriteLine("Программа расчитывает количество раз, которое собака успеет сбегать от одного друга к другому до их встречи.");
Console.Write("Введите скорость первого друга в м/с: ");
uint first_friend_speed = Convert.ToUInt32(Console.ReadLine());
Console.Write("Введите скорость второго друга в м/с: ");
uint second_friend_speed = Convert.ToUInt32(Console.ReadLine());
Console.Write("Введите скорость собаки в м/с: ");
uint dog_speed = Convert.ToUInt32(Console.ReadLine());
if (dog_speed <= first_friend_speed || dog_speed <= second_friend_speed)
{
    Console.Write("Ошибка! Собака не может двигаться медленнее друзей или с такой же скоростью.");
    return;
}
Console.Write("Введите расстояние между друзьями в километрах: ");
uint distance = Convert.ToUInt32(Console.ReadLine());
Console.Write("Какое расстояние в метрах взять за достаточное для встречи друзей?: ");
uint meeting_distance = Convert.ToUInt32(Console.ReadLine());
uint friend = 2;
uint count = 0;
distance *= 1000;
while (distance > meeting_distance)
{
    if (friend == 2)
    {
        distance = distance - distance/(second_friend_speed + dog_speed)*second_friend_speed - distance/(second_friend_speed + dog_speed)*first_friend_speed;
        friend = 1;
        count +=1;
    }
    else
    {
        distance = distance - distance/(first_friend_speed + dog_speed)*first_friend_speed - distance/(first_friend_speed + dog_speed)*second_friend_speed;
        friend = 2;
        count += 1;
    }
}
Console.WriteLine(count + " раз собака успеет пробежать от одного друга к другому");