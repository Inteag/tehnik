#include <iostream>
#include <fstream>
using namespace std;

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char** argv) {
	setlocale(LC_ALL, "RUS");
	int a;
	ifstream vhod1;
	vhod1.open("D:\\����� ����� (2)\\�����",ios::in);
	vhod1>>a;
if(a>4){
cout<<"��������� ����������� ������� ����������� ��� \n";
}
else{
cout<<"�� ������ \n";
}
vhod1.close();
a++;
ofstream vhod2;	
vhod2.open("D:\\����� ����� (2)\\�����",ios::out);
vhod2<<a;
vhod2.close();
system("pause");
	return 0;
}
