// replyBot.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include "alfred.h"
using namespace std;

int main()
{
	string userResponse="temp";
	Alfred bot = Alfred(bot);
	bot.getName();
	bot.greet();
	do {
		userResponse = bot.get();
		//cout << userResponse << endl;
	} while (userResponse != "BYE" /*|| userResponse != "END"*/);



	bot.goodBye();
}
