#pragma once
#include <iostream>
#include <string>
#include <sstream>
#include <vector>

using namespace std;
using std::vector;

class Alfred
{
public: 
	string get();
	void reply(string given);
	Alfred(string name);
	void greet();
	void getName();
	bool search(vector<string> vec, string input);
	int goodBye();
private:
	string name;
	string userName;
	
	
	
	vector<string> split(string line);
	
	bool findString(vector<string> vec ,string search);
};

