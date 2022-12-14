double distance = 10000;
int friendspeed1 = 1, friendspeed2 = 2, dogspeed = 5;
double time;
int count = 0;
int friend = 2;

while (distance >= 10)
{
	if (friend == 2)
    {
		time = distance / (friendspeed2 + dogspeed);
		friend = 1;
    }
	else
    {
		time = distance / (friendspeed1 + dogspeed);
		friend = 2;
    }
	distance = distance - (friendspeed1 + friendspeed2) * time;
	count++;
}
Console.WriteLine($"Dog ran {count} times");
