Console.Clear();

int count = 0;
int distance = 1000;
int firstFriendSpeed = 5;
int secondFriendSpeed = 4;
int dogSpeed = 7;
int friend = 2;
int t = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        t = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        t = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }

    distance = distance - (firstFriendSpeed + secondFriendSpeed) * t;
    count++;
}
    Console.WriteLine ("Счетчик перемещения собаки от друга к другу: ");
    Console.WriteLine(count);