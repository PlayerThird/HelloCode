int count = 0;
double distance = 100000;
int firstFriendSpd = 1, secondFriendSpd = 2, dogSpd = 5;
int friend = 2;
double time = 0;
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance/(firstFriendSpd + dogSpd);
        friend = 2;
    }
    else
    {
        time = distance/(secondFriendSpd + dogSpd);
        friend = 1;
    }
    distance = distance - (firstFriendSpd + secondFriendSpd) * time;
    count ++;
}
Console.WriteLine(count);