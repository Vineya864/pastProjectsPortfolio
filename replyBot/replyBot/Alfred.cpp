#include "Alfred.h"
#include <iostream>
#include <iomanip>
#include <string>
#include <ctime>
#include <stdlib.h>
#include <vector>
#include "Calculator.h"
#include <sstream>
#include <fstream>
#include <algorithm> 
#include <ctime>
using namespace std;

Alfred::Alfred(string name) {//give the bot a name
	name = this->name;
	srand((unsigned)time(0));

}

string Alfred::get() {//split the entry into a vector and seach for key words
	string given;
	cout << "How may I help you? : ";
	getline(cin, given);
	transform(given.begin(), given.end(), given.begin(), ::toupper);
	ifstream MyReadFile("words.txt");
	string temp;
	getline(MyReadFile, temp);
	vector<string> positive = split(temp);
	getline(MyReadFile,temp);
	vector<string> personal = split(temp);
	getline(MyReadFile, temp);
	vector<string> question = split(temp);
	//cout << temp;
	MyReadFile.close();
	bool foundPos = false;
	int i = 0;
	
	/*while(i< size(positive) && !foundPos   ) {
		
		if (findString((split(given)), positive[i])) {
			foundPos = true;
		}
		else {
			foundPos = foundPos;
		}
		i++;
		
	}*/
	if (search(positive,given)) {/*foundPos==true*/
		reply("positive");
	}
	/*else {
		
		bool foundPers = false;
		i = 0;
		while (i < size(personal) && !foundPers) {

			if (findString((split(given)), personal[i])) {
				foundPers = true;
			}
			else {
				foundPers = foundPers;
			}
			i++;

		}*/
		else if (search(question, given)/*foundPers == true*/) {
			
			reply("question");
		}

		else if (search(personal, given)) {
		reply("personal");
	}
	
		else {
			reply("none");
		}
	//}

	
	return given;
}

void Alfred::getName() {//fin the users name
	cout << "What is your name? :";
	getline(cin, userName);	
}

bool Alfred::search(vector<string> vec, string input) {
	bool found = false;
	int i = 0;
	while (i < size(vec) && !found) {

		if (findString((split(input)), vec[i])) {
			found = true;
		}
		else {
			found = found;
		}
		i++;

	}
	if (found == true) {
		return true;
	}
	else {
		return false;
	}
}



void Alfred::reply(string given) {//create a reply


	if (given.compare("positive")==0) {
		int chance = rand() % 4;
		//cout << chance << endl;


		switch (chance) {
		case 1:
			cout << "I'm glad" << endl;
			break;
		case 2:
			cout << "Thats good" << endl;
			break;
		case 3:
			cout << "I'm pleased to hear it " << endl;
			break;
		default:
			cout << "Intresting" << endl;
		}
	}
	else if (given.compare("personal") == 0) {
		int chance = rand() % 4;
		//cout << chance << endl;
		cout << "I am not yet able to give responses about myself " << endl;
		/*
		switch (chance) {
		case 1:
			cout << "I agree" << endl;
			break;
		case 2:
			cout << "Yes" << endl;
			break;
		case 3:
			cout << "I am doing well thankyou; " << endl;
			break;
		default:
			cout << "I'm Fine" << endl;
		}*/
	}
	else if (given.compare("question") == 0) {
		cout << "I dont know the answer to that"<<endl;
	}
	else {
		cout << "I'm afraid I can't help you with that" << endl;
	}
}

void Alfred::greet() {//greet the user
	 cout << "Hello " + userName + ", My name is Alfred" << endl;
}

int Alfred::goodBye() {//end the program
	cout << "GoodBye " + userName + " :" << endl;
	return 0;
}



vector<string> Alfred::split(string line)//split the entry into a vector
{
	std::stringstream ss(line);
	std::istream_iterator<std::string> begin(ss);
	std::istream_iterator<std::string> end;
	std::vector<std::string> vstrings(begin, end);
	return vstrings;
}
bool Alfred::findString(vector<string> vec, string search)//search the vector
{

	if (find(vec.begin(), vec.end(), search) != vec.end()) {
	
		//cout << "found";
		return true;
	
		
	}
	else {
	
		//cout << "not found";
		return false;
	}
}

