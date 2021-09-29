using System;

Console.WriteLine("Du kommer till en övergiven tågstation. Det kommer ett tåg, går du på eller stannar du kvar?");
string direction = Console.ReadLine();

if (direction == "går på")
{
    Console.WriteLine("Du går på tåget men ser att det bara finns en ledig sittplats. Står du eller sätter dig du ner?");
    string stand = Console.ReadLine();
   
    if (stand == "står")
    {
        Console.WriteLine("Du väljer att stå upp och tåget kommer till nästa station. Går du av eller stannar du kvar?");
        string direction2 = Console.ReadLine();

        if (direction2 == "går av")
        {
            Console.WriteLine("Du går av och du märker att tåget stannade precis framför ditt hem. Du går in och somnar. Börja om.");
        }
        else if (direction2 == "stannar kvar")
        {
            Console.WriteLine("Du stannar kvar och åker till slutstationen. Du kliver av och ser att du har hamnat i Narnia. Börja om.");
        }
        else
        {
            Console.WriteLine("Du verkar ha skrivit något fel. Försök igen");
        }
    }
    else if (stand == "sätter mig")
    {
        Console.WriteLine("Personen du sätter dig brevid drar plötsligt framm en kniv och hugger dig i benet. Du går av vid nästa station och letar efter ett sjukhus. Börja om.");
    }
    else
    {
        Console.WriteLine("Du verkar ha skrivit något fel. Försök igen");
    }
}
else if (direction == "stannar kvar")
{
    Console.WriteLine("Du väljer att stanna kvar på stationen och det dyker upp en trappa som leder ner i marken. Stannar du på stationen eller går du ner i trappan?");
    string staircase = Console.ReadLine();

    if (staircase == "stannar kvar")
    {
        Console.WriteLine("Det kommer fram en snigel till dina fötter och säger åt dig att ta något annat val. Börja om");   
    }
    else if (staircase == "går ner")
    {
        Console.WriteLine("Du går ner för trappan och kommer till helvetet. Börja om.");
    }
    else
    {
        Console.WriteLine("Du verkar ha skrivit något fel. Försök igen");
    }
}

else
{
    Console.WriteLine("Du verkar ha skrivit något fel. Försök igen");
}

Console.ReadLine();
